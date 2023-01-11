# MrEmilProjekt

# Beskrivning  
Detta projekt är skapt för att öva på bra oop! Programmet går ut på att man ska kunna välja bland 3 alternativ.
1 : Shapes. Räkna ut area och omkrets på oilka former + möjligt att använda CRUD på dessa beräknigar.
2 : Miniräknare. En fungerande miniräknare + möjligt att använda CRUD på dessa beräknigar.
3 : Sten,sax,påse. Kunna spela spelet och även räkna ut genomsnittet av alla vinster vid den tidpunkten.
All relevant information av dessa 3 alternativ sparas ner till samma databas.

# Technologies
:---- Console app .Net 6.0 ---- microsoft.entityframeworkcore.sqlserver\6.0.0\ ---- 
microsoft.entityframeworkcore.tools\6.0.0\ ---- microsoft.extensions.configuration.json\6.0.0\


# Metoder
Run() Görs valet vad man vill köra av shapes,calculator,rock,paper,scissors.
ShowMenu() Visar valen shapes,calculator,rock,paper,scissors och retunerar ett val.
ShowShapesMenu() visar de val som finns att göra och skickar vidare till önskat val.
RectangleManager() Samlar information från andra metoder för att få ut rektangelns area och omkrets. skriver ut resultat och sparar till databas.
ParaellogramManager() Samlar information från andra metoder för att få ut paraellogramets area och omkrets. skriver ut resultat och sparar till databas.
TriangleManager() Samlar information från andra metoder för att få ut triangelns area och omkrets. skriver ut resultat och sprar till databas.
RombManager() Samlar information från andra metoder för att få ut rombens area och omkrets. skriver ut resultat och sprar till databas.
ShapeWidthInput() Retunerar en bas i form av en double som användaren matat in.
ShapeHeightInput() Retunerar en höjd i from av en double som användaren matat in.
ResultMessageShape() Skriver ut resultat av area och omkrets och navigerar användaren vidare.
ErrorMessage() Skriver ut vilket  fel val av input som gjorts och navigerar användaren vidare.







