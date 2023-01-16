# MrEmilProjekt

# Beskrivning  
Programmet går ut på att man ska kunna välja bland 3 alternativ.
Shapes : Räkna ut area och omkrets på oilka former + möjligt att använda CRUD på dessa beräknigar.
Miniräknare : En fungerande miniräknare + möjligt att använda CRUD på dessa beräknigar.
Sten,sax,påse : Kunna spela spelet och även räkna ut genomsnittet av alla vinster vid den tidpunkten.
All relevant information av dessa 3 alternativ sparas ner till samma databas.

# Technologies
:---- Console app .Net 6.0 ---- microsoft.entityframeworkcore.sqlserver\6.0.0\ ---- 
microsoft.entityframeworkcore.tools\6.0.0\ ---- microsoft.extensions.configuration.json\6.0.0\


# Metoder
#Shapes
Run() Görs valet vad man vill köra av shapes,calculator,rock,paper,scissors.
ShowMenu() Visar valen shapes,calculator,rock,paper,scissors och retunerar ett val.
ShowShapesMenu() Visar de val som finns att göra och skickar vidare till önskat val.
ResultMessageShape() Skriver ut resultat av area och omkrets och navigerar användaren vidare.
ErrorMessage() Skriver ut vilket  fel val av input som gjorts och navigerar användaren vidare.
CreateRectangle() Skapar en rektangel och sparar till databasen.
CreateParaellogram() Skapar ett paraellogram och sparar till databasen
CreateTriangle()  Skapar en triangel och sparar till databasen
CreateRomb()  Skapar en romb och sparar till databasen
AreaCalculator() Räknar ut area på önskad form.
PeremiterCalculator() Räknar ut omkrets på önskad form.
AreaCalculatorTriangel() Räknar ut area på en triangel.
PeremiterCalculatorTriangel() Räknar ut omkrets på en triangel.
ListShape() Listar alla shapes.
UpdateShape() Möjlighet att ändra värden i en shape som redan skapats.
DeleteShape() Möjlighet att radera en shape som redan skapats.
GetShapeId() Väljer ett shapeId från lista och retunerar det.
NotValidIdMessage() Skriver ut felmeddelande.
SuccsessMessage() Skriver ut ett lyckades meddelande.

#RockPaperSissors
PlayGame() Spelar spelet tills man väljer att avsluta.
ShowGameStats() Visar hur mycket spelaren vunnit i procent.
GameStats() Sparar all relevant iformation till databasen.
Average() Räknar ut hur mycket spelaren vunnit i procent.
WinMessage() Visar att spelaren vunnit och frågar om den vill spela igen.
LooseMessage() 
DrawMessage()






 







