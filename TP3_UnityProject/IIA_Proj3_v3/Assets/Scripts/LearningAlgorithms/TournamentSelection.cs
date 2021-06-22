using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
public class TournamentSelection : SelectionMethod
{
	private int tournamentSize;

	public TournamentSelection(int tournamentSize) : base()
	{
		this.tournamentSize = tournamentSize;
	}

	public override List<Individual> selectIndividuals(List<Individual> oldpop, int num)
	{
		if (oldpop.Count < tournamentSize)
		{
			throw new System.Exception("The population size is smaller than the tournament size.");
		}

		List<Individual> selectedInds = new List<Individual>();
		for (int i = 0; i < num; i++)
		{
			selectedInds.Add(tournamentSelection(oldpop,tournamentSize).Clone());
		}

		return selectedInds;
	}

    /************************************ OUR CODE BELOW ********************************/
    // PSEUDOCODIGO SELEÇÃO

    public Individual tournamentSelection(List<Individual> population, int tournamentSize)
    {
        Individual best = null;
        List<Individual> tempList = new List<Individual>();
        int temp = 0;

        while (temp < tournamentSize - 1)
        {
            Individual tempInd = population[Random.Range(0, population.Count - 1)];

            if (tempList.Count > 0)
            {
                for (int j = 0; j < tempList.Count; j++)
                {
                    if (tempInd != tempList[j]) tempList.Add(tempInd);
                    temp++;
                }
            }
            else tempList.Add(tempInd);

            if (best == null || tempInd.Fitness > best.Fitness) best = tempInd.Clone();
        }

        return best;
    }

    //throw new System.NotImplementedException();


    /*Individual best = null;

    for(int i = 0; i < tournamentSize; i ++){
            Individual tempInd = population[Random.Range(0, population.Count - 1)];
            if (best == null || tempInd.Fitness > best.Fitness) best = tempInd.Clone();
        }

        return best;
    }*/

    /************************************ OUR CODE ABOVE ********************************/
}
