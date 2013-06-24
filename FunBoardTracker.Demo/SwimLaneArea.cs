using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FunBoardTracker.Jira;

namespace FunBoardTracker.Demo
{
    public class SwimLanePolygon
    {
        public Point[] Area { get; set; }
        public List<Status> JiraStatuses { get; set; }
        public BoardStatus BoardStatus { get; set; }

        public SwimLanePolygon(Point[] points, List<Status> statuses, BoardStatus status)
        {
            Area = points;
            JiraStatuses = statuses;
            BoardStatus = status;
        }


        public bool PointInArea(Point p)
        {
            Point p1, p2;
            bool inside = false;

            if (Area.Length < 3)
            {
                return inside;
            }

            Point oldPoint = new Point(Area[Area.Length - 1].X, Area[Area.Length - 1].Y);

            for (int i = 0; i < Area.Length; i++)
            {
                Point newPoint = new Point(Area[i].X, Area[i].Y);

                if (newPoint.X > oldPoint.X)
                {
                    p1 = oldPoint;
                    p2 = newPoint;
                }
                else
                {
                    p1 = newPoint;
                    p2 = oldPoint;
                }

                if ((newPoint.X < p.X) == (p.X <= oldPoint.X)
                && ((long)p.Y - (long)p1.Y) * (long)(p2.X - p1.X)
                 < ((long)p2.Y - (long)p1.Y) * (long)(p.X - p1.X))
                {
                    inside = !inside;
                }

                oldPoint = newPoint;
            }

            return inside;
        }

        public static SwimLanePolygon GetSwimLaneAreaByPoints(List<Status> statuses, BoardStatus status, Point topLeft, Point bottomLeft, Point topRight, Point bottomRight, int height)
        {
            return new SwimLanePolygon(new Point[]
                {
                    GetTopPoint(topLeft, bottomLeft, 1),
                    GetTopPoint(topRight, bottomRight, 1),
                    GetBottomPoint(topRight, bottomRight, height),
                    GetBottomPoint(topLeft, bottomLeft, height)
                }, statuses, status);
        }

        private static Point GetTopPoint(Point top, Point bottom, int y)
        {
            int x = top.X;
            if (bottom.X - top.X != 0)
                x = (int)(((y - top.Y) / ((bottom.Y - top.Y) / (bottom.X - top.X))) + top.X);

            return new Point(x, y);
        }

        private static Point GetBottomPoint(Point top, Point bottom, int y)
        {
            int x = bottom.X;
            if (bottom.X - top.X != 0)
                x = (int)(((y - bottom.Y) / ((bottom.Y - top.Y) / (bottom.X - top.X))) + bottom.X);

            return new Point(x, y);
        }
    }
}
