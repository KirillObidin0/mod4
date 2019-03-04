using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod4
{
    public enum BodyType
    {
        Sedan,
        Hatchback,
        SUV
    }
    public enum Color
    {
        Black,
        White,
        Green,
        Red
    }
    public partial class Car
    {
        static int AverageMaxSpeed;
        static string LicensePlateTemplate;
        static Car()
        {
            AverageMaxSpeed = 180;
            LicensePlateTemplate = "000 aaa 00";
        }

        private string Model;
        private double EngineVolume;
        private int YearOfIssue;
        private BodyType BodyType;
        private Color Color;

        public Car()
        {
            Model = "Toyota Corolla";
            EngineVolume = 1.6;
            YearOfIssue = 2005;
            BodyType = BodyType.Sedan;
            Color = Color.Black;
        }
        public Car(string model,double engineVolume,int yearOfIssue, BodyType body,Color color)
        {
            Model = model;
            EngineVolume = engineVolume;
            YearOfIssue = yearOfIssue;
            BodyType = body;
            Color = color;
        }
        

        public string GetModel()
        {
            return Model;
        }
        public double GetEngineVolume()
        {
            return EngineVolume;
        }
        public int GetYearOfIssue()
        {
            return YearOfIssue;
        }
        public BodyType GetBodyType()
        {
            return BodyType;
        }
        public Color GetColor()
        {
            return Color;
        }

        public string GetInfo()
        {
            string res = Model + ' ' + YearOfIssue + ' ' + 
                EngineVolume + ' ' + BodyType + ' ' + Color;
            return res;
        }

        public void SetColor(Color color)
        {
            Color = color;
        }

    }
}
