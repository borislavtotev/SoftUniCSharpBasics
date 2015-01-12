using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PerimeterAndAreaPolygon
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        List<int[]> PointList = new List<int[]>();

        for (int i = 0; i < n; i++)
        {
            string NewPointStr = Console.ReadLine();
            string[] PointCordinates = NewPointStr.Split(' ');
            int[] NewPointCordinates = Point(PointCordinates[0], PointCordinates[1]);
            PointList = Polygon(PointList, NewPointCordinates);
        }

        Perimeter(PointList);
        Area(PointList);
    }

    private static List<int[]> Polygon(List<int[]> PointList, int[] NewPointCordinates)
    {
        PointList.Add(NewPointCordinates);
        return PointList;
    }

    private static int[] Point(string x, string y)
    {
        int XInt = Convert.ToInt32(x);
        int YInt = Convert.ToInt32(y);

        int[] NewPoint = new int[2];
        NewPoint[0] = XInt;
        NewPoint[1] = YInt;
        
        return NewPoint;

    }
    private static void Perimeter(List<int[]> PointList)
    {
        double perimetyr = 0;

        for (int i = 0; i < PointList.Count; i++)
        {
            int j = 0;
            if (i+1 != PointList.Count)
            {
                j = i + 1; 
            } 
            perimetyr += Math.Sqrt( Math.Pow((PointList[i][0]-PointList[j][0]),2) + Math.Pow((PointList[i][1]-PointList[j][1]),2) );
        }

        Console.WriteLine("perimeter = {0:0.00}",perimetyr);

    }
    private static void Area(List<int[]> PointList)
    {
        double area = 0;

        for (int i = 0; i < PointList.Count; i++)
        {
            int j = 0;
            if (i+1 != PointList.Count)
            {
                j = i + 1; 
            }
            area += PointList[i][0] * PointList[j][1] - PointList[i][1] * PointList[j][0];
        }

        area = Math.Abs(area / 2);

        Console.WriteLine("area = {0:0.00}",area);
    }
}


