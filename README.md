# MrEmilProjekt ![Juggernaut2](https://user-images.githubusercontent.com/113430950/212973417-6b43a90f-937c-4e04-b50c-9c535e349578.png)




# Beskrivning

Detta är ett program där man får tre val. Dessa val består av Shapes,Calculator,RockPaperScissors :



         
         
                                             |      ****         1:  Shapes               ****  |");
                                             |      ****         2:  Calculator           ****  |");
                                             |      ****         3:  Rock,Paper,Scissors  ****  |");
                                             |      ****         0:  Exit                 ****  |");
                                           ----------------------------------------------------");


Väljer du Shapes får du dessa val :

           
                                                | ****      1:   Rectangle  **** |");
            
                                                | ****   2: Parallelogram   **** |");
           
                                                 | ****     3: Triangle     **** |");
           
                                                 | ****      4: Rhombus    **** |");
            
                                                 | ****      5:  List       **** |");
         
                                                 | ****      6:  Update     **** |");
            
                                                 | ****      7:  Delete       **** |");
            
                                                 |  ****      0:  Mainmen   **** |");
                                                 -----------------------------------
                                           
 Du väljer en form igenom att skriva siffran som står framför. Efter du valt form får du möjlighet att räkna ut dess area och omkrets. Detta gör du igenom att skriva in de längder som kommer upp på skärmen. List: listar alla former som finns i databasen. Update: Finns möjlighet att uppdatera datan som finns i en form. Delete: Möjlighet att radera en form.

Väljer du Calculator får du dessa val: 

                                                 |     ***  1 : Make Calculation   ****    |");
                                                 |     ***  2 : List all           ****    |");
                                                 |     ***  3 : Update             ****    |");
                                                 |     ***  4 : Delete             ****    |");
                   
                                                 |     ***  0: Mainmeny            ****   |");
                                                 ---------------------------------------------
                                                 

List,Update,Delete gör samma sak som i shapes fast med "Calculation datan".
Väljer du Make Calculation får du dessa val:


                                        
              
                                              ******* Choose Operator *********
                                       --------------------------------------------");
                                         |      ****           +          ****    |");
                                         |      ****           -          ****    |");
                                         |      ****           /          ****    |");
                                         |      ****           *          ****    |");
                                         |      ****        1: √          ****    |");
                                         |      ****           %          ****    |");

                                         |      ****        0: Exit       ****    |");
                                       ---------------------------------------------");
                                       
                                       
 Du väljer vilken typ av uträkningen du vill göra genom att skriva in något av dessa tecken ovanför...   
 
 
                                   

Väljer du att spela RockPaperScissors kommer du direkt att börja spela spelet. Vill du sluta spela, skriv end. Du spelar spelet igenom att skriva något
utav dessa val: ROCK,PAPER eller SCISSORS


# Program
:---- Console app .Net 6.0 ---- microsoft.entityframeworkcore.sqlserver\6.0.0\ ---- 
microsoft.entityframeworkcore.tools\6.0.0\ ---- microsoft.extensions.configuration.json\6.0.0\


# Patterns/Principer
I programmet använder vi Strategy Pattern i Calculator delen. Dependency Injection finns också med. Programmet i helhet försöker hålla Single-principle responsibility.
Inheritance/Interface. Encapsulation, några properties i Shapes är private som exempel på den principen. Abstraction, relevanta namn på metoder och variabler.



# Metoder






![ogway](https://user-images.githubusercontent.com/113430950/213250630-60e75834-7161-42ea-8382-d3b1a428f0d5.jpg)

























Metoder        | Kort beskrivning           |
| ------------- |:-------------:|
| Run()| Här körs programmet ifrån. |
| ShowMenu()     | Visar valen shapes,calculator,rock,paper,scissors och retunerar ett val.    |
| ShowShapesMenu() | Visar de val som finns att göra och skickar vidare till önskat val. |    
| ResultMessageShape() | Skriver ut resultat av area och omkrets och navigerar användaren vidare. |
| ErrorMessage() | Skriver ut vilket  fel val av input som gjorts och navigerar användaren vidare. |
| CreateRectangle() | Skapar en rektangel och sparar till databasen. |
| CreateParaellogram() | Skapar ett paraellogram och sparar till databasen. |
| CreateTriangle() | Skapar en triangel och sparar till databasen. |
| CreateRomb() | Skapar en romb och sparar till databasen. |
| AreaCalculator() | Räknar ut area på tvåsidig form. |
| PerimiterCalculator() | Räknar ut omkrets på önskad form. |
| AreaCalculatorTriangel() | Räknar ut area på en triangel. |
| PerimiterCalculatorTriangel() | Räknar ut omkrets på en triangel. |
| ListShape() | Listar alla shapes. | 
| UpdateShape() | Möjlighet att ändra värden i en shape som redan skapats. |
| DeleteShape() | Möjlighet att radera en shape som redan skapats. |
| GetShapeId() | Väljer ett shapeId från lista och retunerar det. |
| NotValidIdMessage() | Skriver ut felmeddelande. |
| SuccsessMessage() | Skriver ut ett lyckades meddelande. |
| PlayGame() | Spelar RockPaperScissors. |
| ShowGameStats() | Visar hur mycket spelaren vunnit i procent. |
| SaveGameStats() | Sparar all relevant iformation till databasen. |
| Average() | Räknar ut hur mycket spelaren vunnit i procent. |
| WinMessage() | Visar att spelaren vunnit och frågar om den vill spela igen. |
| LooseMessage() | Visar att spelaren förlorat och frågar om den vill spela igen. |
| DrawMessage() | Visar Oavgjort och frågar om att spela igen. |
| CalculatorMenu() | Visar de val som finns att göra och skickar användren vidare till önskat val. |
| OperatorMenu() | Visar vilka operatorer användaren kan välja och skickar användaren vidare till önskat val. |
| AdditionCalculator() | Gör en addition uträkning av två tal. |
| SubtractionCalculator() | Gör en subtraktion av två tal. |
| DividedCalculator() | Gör en division av två tal. |
| ModuloCalculator() | Räknar modulos på två tal. |
| MultiplyCalculator() | Gör ut multiplikation av två tal. |
| SqrtCalculator() | Räknar ut roten av ett tal. |
| SaveCalcToDataBase() | Sparar en uträknings resultat och tid till databasen. |
| NumberInput() | Användaren får skriva in ett nummer som retuneras. |






 






