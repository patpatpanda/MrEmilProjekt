namespace MrEmilProjekt.Shapes
{
    public interface IShapeFactory {
        Shape CreateParaellogram(double bas, double height);
        Shape CreateRomb(double bas, double height);
        Shape CreateRectangle(double bas, double height);

        Shape CreateTriangel(double bas, double height,double hypotenusa);

        Shape CreateNewShape();


    }
}