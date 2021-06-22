# IIA_D31_The-Rise-of-the-Ballz
Projeto académico concebido no âmbito da disciplina de Introdução à Inteligência Artificial do curso de LDM da Universidade de Coimbra

Background:
This practical project focuses on evolving the D31 unit into a more intelligent unit over hundreds of simulations. To do this, we are required to use the genetic algorithm to modify and mutate newer units while inheriting older unit genes. The robot unit will have to learn how to play football, both as an attacker and a defender. There are two units, an attacker and a defender. The attacker will attempt to learn how control the ball and score a goal while the defender will learn how to defend his goals and try to not allow any goals enter by hitting the ball away.

Methods:
The implementation of allowing the evolution of the unit is done using the genetic algorithm as well as some controllers specified for the role (defender, attacker). The genetic algorithm needs a few algorithms to be implemented; These algorithms are namely the crossover algorithm (In order to crossover genes to newer generations) and gaussian mutation algorithm (In order to mutate new units at the beginning of each generation). In addition, a tournament selection algorithm (In order to choose the best unit of the generation to pass over the genes) along with two different fitness functions (controllers for the unit to be able to know what to learn) will also be needed for implementation.

Objective:
Our objective in this practical work is to create controllers for the unit so that the ability to know what to learn is achieved, in this case – to play football. These controllers will focus on defending, controlling the ball and playing against one another.
