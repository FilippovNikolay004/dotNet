struct ComplexNumber {
    public double Real { get; }
    public double Imaginary { get; }

    public ComplexNumber(double real, double imaginary) {
        Real = real;
        Imaginary = imaginary;
    }

    public static ComplexNumber Add(ComplexNumber a, ComplexNumber b) {
        return new ComplexNumber(a.Real + b.Real, a.Imaginary + b.Imaginary);
    }

    public static ComplexNumber Subtract(ComplexNumber a, ComplexNumber b) {
        return new ComplexNumber(a.Real - b.Real, a.Imaginary - b.Imaginary);
    }

    public static ComplexNumber Multiply(ComplexNumber a, ComplexNumber b) {
        return new ComplexNumber((a.Real * b.Real - a.Imaginary * b.Imaginary), (a.Real * b.Imaginary + a.Imaginary * b.Real));
    }

    public static ComplexNumber Divide(ComplexNumber a, ComplexNumber b) {
        double denom = b.Real * b.Real + b.Imaginary * b.Imaginary;
        return new ComplexNumber(((a.Real * b.Real + a.Imaginary * b.Imaginary) / denom), 
                            ((a.Imaginary * b.Real - a.Real * b.Imaginary) / denom));
    }
    public override string ToString() {
        return $"{Real} {(Imaginary >= 0 ? "+" : "-")} {Math.Abs(Imaginary)}i";
    }
}

class MainClass {
    public static void Main() {
        ComplexNumber complexNumber1 = new ComplexNumber(3, 2);
        ComplexNumber complexNumber2 = new ComplexNumber(1, 4);

        ComplexNumber result = new ComplexNumber();

        result = ComplexNumber.Add(complexNumber1, complexNumber2);
        Console.WriteLine(result);

        result = ComplexNumber.Subtract(complexNumber1, complexNumber2);
        Console.WriteLine(result);

        result = ComplexNumber.Multiply(complexNumber1, complexNumber2);
        Console.WriteLine(result);

        result = ComplexNumber.Divide(complexNumber1, complexNumber2);
        Console.WriteLine(result);
    }
}