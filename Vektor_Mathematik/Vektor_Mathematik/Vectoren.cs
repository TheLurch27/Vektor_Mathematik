using System;

// Vektor-Klasse repräsentiert einen 3D-Vektor
public class Vector
{
    // Drei float Attribute: x, y, z
    public float x, y, z;

    public float defaultZero = 0f;

    // Standardkonstruktor setzt x, y, z auf 0
    public Vector()
    {
        x = y = z = defaultZero;
    }

    // Konstruktor initialisiert x, y, z mit Parametern
    public Vector(float _x, float _y, float _z)
    {
        x = _x;
        y = _y;
        z = _z;
    }

    // + Operator für die Addition mit einem anderen Vector
    public static Vector operator +(Vector _v1, Vector _v2)
    {
        return new Vector(_v1.x + _v2.x, _v1.y + _v2.y, _v1.z + _v2.z);
    }

    // - Operator für die Subtraktion mit einem anderen Vector
    public static Vector operator -(Vector v1, Vector v2)
    {
        return new Vector(v1.x - v2.x, v1.y - v2.y, v1.z - v2.z);
    }

    // * Operator für die Multiplikation mit einem Scalar (Zahl)
    public static Vector operator *(Vector v, float scalar)
    {
        return new Vector(v.x * scalar, v.y * scalar, v.z * scalar);
    }

    // Methode die die Distanz zwischen zwei Vektoren berechnet
    public float Distance(Vector other)
    {
        float dx = x - other.x;
        float dy = y - other.y;
        float dz = z - other.z;
        return (float)Math.Sqrt(dx * dx + dy * dy + dz * dz);
    }

    // Statische Methode für die Distanz zwischen zwei Vektoren
    public static float StaticDistance(Vector v1, Vector v2)
    {
        float dx = v1.x - v2.x;
        float dy = v1.y - v2.y;
        float dz = v1.z - v2.z;
        return (float)Math.Sqrt(dx * dx + dy * dy + dz * dz);
    }

    // Methode die die Länge eines Vektors berechnet
    public float Length()
    {
        return (float)Math.Sqrt(x * x + y * y + z * z);
    }

    // Methode die die Quadratlänge eines Vektors berechnet
    public float SquaredLength()
    {
        return x * x + y * y + z * z;
    }
}
