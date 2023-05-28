// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// P.S. Расстояние меsжду точками — это число, равное корню из суммы квадратов разностей координат точек или длине разности радиус-векторов точек.

double GetDistanceBetweenPointsIn3D(CoordinatesOfPoint coordinatesFirstPoint, CoordinatesOfPoint coordinatesSecondPoint)
{
    return Math.Sqrt(
        Math.Pow(coordinatesSecondPoint.x - coordinatesFirstPoint.x, 2)
        +
        Math.Pow(coordinatesSecondPoint.y - coordinatesFirstPoint.y, 2)
        +
        Math.Pow(coordinatesSecondPoint.z - coordinatesFirstPoint.z, 2)
    );
}

CoordinatesOfPointsForDifference firstCoordinatesOfPointsForDifference = new CoordinatesOfPointsForDifference();
firstCoordinatesOfPointsForDifference.SetCoordinatesOfPoints(new int[] { 3, 6, 8 }, new int[] { 2, 1, -7 });

CoordinatesOfPointsForDifference secondCoordinatesOfPointsForDifference = new CoordinatesOfPointsForDifference();
secondCoordinatesOfPointsForDifference.SetCoordinatesOfPoints(new int[] { 7, -5, 0 }, new int[] { 1, -1, 9 });

Console.WriteLine(
    GetDistanceBetweenPointsIn3D(
        firstCoordinatesOfPointsForDifference.coordinatesOfPointA,
        firstCoordinatesOfPointsForDifference.coordinatesOfPointB
    )
);

Console.WriteLine(
    GetDistanceBetweenPointsIn3D(
        secondCoordinatesOfPointsForDifference.coordinatesOfPointA,
        secondCoordinatesOfPointsForDifference.coordinatesOfPointB
    )
);

public class CoordinatesOfPoint
{
    public int x { get; set; }
    public int y { get; set; }
    public int z { get; set; }

    public void SetCoordinates(int[] array)
    {
        x = array[0];
        y = array[1];
        z = array[2];
    }
}

public class CoordinatesOfPointsForDifference
{
    public CoordinatesOfPoint coordinatesOfPointA = new CoordinatesOfPoint();
    public CoordinatesOfPoint coordinatesOfPointB = new CoordinatesOfPoint();

    public void SetCoordinatesOfPoints(int[] arrayCoordinatesOfPointA, int[] arrayCoordinatesOfPointB)
    {
        coordinatesOfPointA.SetCoordinates(arrayCoordinatesOfPointA);
        coordinatesOfPointB.SetCoordinates(arrayCoordinatesOfPointB);
    }
}