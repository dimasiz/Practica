using System;
using System.Windows.Media;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    public class TestDrawing : Control
    {
        protected override void OnRender(DrawingContext drawingContext)
        {
            base.OnRender(drawingContext);

            Point[] trianglePoints = { new Point(50, 50), new Point(150, 50), new Point(100, 150) };
            SolidColorBrush triangleBrush = new SolidColorBrush(Colors.Blue);
            Pen trianglePen = new Pen(Brushes.Black, 2);

            StreamGeometry triangleGeometry = new StreamGeometry();
            using (StreamGeometryContext ctx = triangleGeometry.Open())
            {
                ctx.BeginFigure(trianglePoints[0], true, true);
                ctx.LineTo(trianglePoints[1], true, false);
                ctx.LineTo(trianglePoints[2], true, false);
            }

            drawingContext.DrawGeometry(triangleBrush, trianglePen, triangleGeometry);

          
            Rect ellipseRect = new Rect(200, 50, 100, 150);
            SolidColorBrush ellipseBrush = new SolidColorBrush(Colors.Red);
            Pen ellipsePen = new Pen(Brushes.Black, 2);
            drawingContext.DrawEllipse(ellipseBrush, ellipsePen, new Point(ellipseRect.Left + ellipseRect.Width / 2, ellipseRect.Top + ellipseRect.Height / 2), ellipseRect.Width / 2, ellipseRect.Height / 2);

            SolidColorBrush circleBrush = new SolidColorBrush(Colors.Green);
            Pen circlePen = new Pen(Brushes.Black, 2);
            drawingContext.DrawEllipse(circleBrush, circlePen, new Point(350, 125), 50, 50);

           
            Rect rectangleRect = new Rect(450, 50, 100, 150);
            SolidColorBrush rectangleBrush = new SolidColorBrush(Colors.Orange);
            Pen rectanglePen = new Pen(Brushes.Black, 2);
            drawingContext.DrawRectangle(rectangleBrush, rectanglePen, rectangleRect);

            SolidColorBrush sectorBrush = new SolidColorBrush(Colors.Yellow);
            Pen sectorPen = new Pen(Brushes.Black, 2);
            drawingContext.DrawGeometry(sectorBrush, sectorPen, GenerateSectorGeometry(new Point(600, 125), 50, 0, 90));
        }

        private Geometry GenerateSectorGeometry(Point center, double radius, double startAngle, double sweepAngle)
        {
            PathFigure pathFigure = new PathFigure();
            pathFigure.StartPoint = center;

            double radiansPerDegree = Math.PI / 180;
            double startRadians = startAngle * radiansPerDegree;
            double sweepRadians = sweepAngle * radiansPerDegree;

            Point startPoint = new Point(center.X + radius * Math.Cos(startRadians), center.Y + radius * Math.Sin(startRadians));
            pathFigure.Segments.Add(new LineSegment(startPoint, isStroked: true));

            pathFigure.Segments.Add(new ArcSegment(
                new Point(center.X + radius * Math.Cos(startRadians + sweepRadians), center.Y + radius * Math.Sin(startRadians + sweepRadians)),
                new Size(radius, radius),
                0, 
                sweepAngle > 180, 
                sweepAngle > 0 ? SweepDirection.Clockwise : SweepDirection.Counterclockwise,
                isStroked: true
                ));

            pathFigure.Segments.Add(new LineSegment(center, isStroked: true));

            PathGeometry pathGeometry = new PathGeometry();
            pathGeometry.Figures.Add(pathFigure);

            return pathGeometry;
        }
    }
}
