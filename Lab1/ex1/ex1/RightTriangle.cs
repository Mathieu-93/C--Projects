using System;

namespace ex1{
    class RightTriangle
    {
        // pola klasy przechowujace dlugosci przyprostokatnych
        private double a;
        private double b;
        // wlasciwosci klasy odpowiadajace powyzszym polom
        public double A
        {
            get { return a; } // prosty getter - tylko zwraca wartosc
            set // setter - pozwoli ustawic wartosc tylko jesli jest dodatnia
            {
                if (value > 0) a = value; // prosze zwrocic uwage na slowo kluczowe value
            }
        }
        public double B
        {
            get { return b; } // prosty getter - tylko zwraca wartosc
            set // setter - pozwoli ustawic wartosc tylko jesli jest dodatnia
            {
                if (value > 0) b = value;
            }
        }
        // metoda klasy obliczajaca tangens kata w trojkacie A/B
        public double ComputeTangent()
        {
            return A / B;
        }

        private double ComputeC()
        {
            return Math.Sqrt(A *A + B * B);
        }

        public double ComputeSine(){
            return A/ComputeC();
        }

        public double Color{ get; set; }

        public double Circumference{
            get{return A+B+ComputeC();}
        }
    }
}