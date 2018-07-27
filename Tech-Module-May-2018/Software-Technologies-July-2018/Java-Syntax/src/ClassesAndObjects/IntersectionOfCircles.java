package ClassesAndObjects;

import java.util.Arrays;
import java.util.Scanner;

public class IntersectionOfCircles {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int[] first = Arrays.stream(scanner.nextLine().split(" ")).mapToInt(Integer::parseInt).toArray();
        int[] second = Arrays.stream(scanner.nextLine().split(" ")).mapToInt(Integer::parseInt).toArray();

        Circle firstCircle = new Circle(first[0], first[1], first[2]);
        Circle secondCircle = new Circle(second[0], second[1], second[2]);

        System.out.println(firstCircle.Intersect(secondCircle) ? "Yes" : "No");
    }
}
class Point {
    public int getX() {
        return X;
    }

    public int getY() {
        return Y;
    }

    public void setX(int x) {
        X = x;
    }

    public void setY(int y) {
        Y = y;
    }

    public Point(int x, int y) {
        this.X = x;
        this.Y = y;
    }

    public int X;
    public int Y;
}

class Circle {
    public Point Center;
    public int Radius;

    public Circle(int x, int y, int radius) {
        this.Center = new Point(x, y);
        this.Radius = radius;
    }

    public Point getCenter() {
        return Center;
    }

    public void setCenter(Point center) {
        Center = center;
    }

    public int getRadius() {
        return Radius;
    }

    public void setRadius(int radius) {
        Radius = radius;
    }

    public boolean Intersect(Circle circle2) {
        double distanceBetweenCenters = Math.sqrt(
                Math.pow(Math.abs(this.Center.X - circle2.Center.X), 2) +
                        Math.pow(Math.abs(this.Center.Y - circle2.Center.Y), 2));
        return distanceBetweenCenters <= (this.Radius + circle2.Radius);
    }
}

