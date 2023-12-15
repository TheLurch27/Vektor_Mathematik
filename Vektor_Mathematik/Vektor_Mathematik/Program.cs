using System;

class Program
{
    static void Main()
    {
        // Beispiel der Verwendung
        Vector v1 = new Vector(-3.0f, -4.0f, -8.0f);
        Vector v2 = new Vector(6.0f, 9.0f, 5.0f);

        Vector resultAdd = v1 + v2;
        Vector resultSub = v1 - v2;
        Vector resultMul = v1 * 5f;

        float distance = v1.Distance(v2);
        float staticDistance = Vector.StaticDistance(v1, v2);

        float lengthV1 = v1.Length();
        float squaredLengthV1 = v1.SquaredLength();

        // Ausgabe der Ergebnisse
        Console.WriteLine("Addition: {0}, {1}, {2}", resultAdd.x, resultAdd.y, resultAdd.z);
        Console.WriteLine("Subtraction: {0}, {1}, {2}", resultSub.x, resultSub.y, resultSub.z);
        Console.WriteLine("Multiplication: {0}, {1}, {2}", resultMul.x, resultMul.y, resultMul.z);
        Console.WriteLine("Distance: {0}", distance.ToString(format: "F2"));
        Console.WriteLine("Static Distance: {0}", staticDistance.ToString(format: "F2"));
        Console.WriteLine("Length: {0}", lengthV1.ToString(format: "F2"));
        Console.WriteLine("Squared Length: {0}", squaredLengthV1.ToString(format: "F2"));
    }
}