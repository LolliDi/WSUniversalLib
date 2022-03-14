using System;

namespace WSUniversalLib
{
    public class Calculation
    {
        public int GetQuantityForProduct(int productType, int materialType, int count, float width, float length)
        {
            try
            {
                float ratioTypeProduct;
                switch(productType)
                {
                    case 1:
                        ratioTypeProduct = 1.1f;
                        break;
                    case 2:
                        ratioTypeProduct = 2.5f;
                        break;
                    case 3:
                        ratioTypeProduct = 8.43f;
                        break;
                    default:
                        throw new Exception("Нет такого типа продуктов");
                }
                float percentRejectMaterial;
                switch(materialType)
                {
                    case 1:
                        percentRejectMaterial = 0.3f;
                        break;
                    case 2:
                        percentRejectMaterial = 0.12f;
                        break;
                    default:
                        throw new Exception("Нет такого типа материалов");
                }
                float squareProduct;
                if (width>0 && length>0)
                {
                    squareProduct = width * length;
                }
                else
                {
                    throw new Exception("Невозможно расчитать площадь");
                }
                if(count<1)
                {
                    throw new Exception("Неверное количество материала");
                }
                return (int)Math.Ceiling(count*squareProduct*ratioTypeProduct/(1-percentRejectMaterial/100));
            }
            catch
            {
                return -1;
            }
            
        }
    }
}
