package com.company;

public class Main {

    static double function(double x, double y, double z) {
        return -2*x*z - 2*y + 4*x;
    }

    static double eyler(double x, double y, double z, double h, double b) {
        double y1 = y, z1 = z, x1 = x;
        while (x1 <= b) {
            y1 = y1 + h * z1;
            z1 = z1 + h * function(x1, y1, z1);
            x1 = x1 + h;
        }
        return y1;
    }

    static void show(double x, double y, double z, double h, double b) {
        double y1 = y, z1 = z, x1 = x, y0;;
//        System.out.println(x1 + "  " + y1);
        while (x1 < b) {
            System.out.println(x1 + "  " + y1);
            y0 = y1;
            y1 = y1 + h * z1;
            z1 = z1 + h * function(x1, y0, z1);
            x1 = x1 + h;

        }
    }

    public static void main(String[] args) {
        double x, A, z, h, a, b, e, B;
        double C1, C2, y1, y2;
        double buf;
        a = 0;
        b = 0.5;
        A = 0;
        B = 1.279;
        x = a;
        h = 0.05;
        e = 0.0001;
        C1 = 1;
        C2 = 0.8;
        y1 = eyler(x, A, C1, h, b);
        y2 = eyler(x, A, C2, h, b);
        if (Math.abs(y2 - B) > Math.abs(y1 - B)) {
            buf = C2;
            C2 = C1;
            C1 = buf;
            buf = y2;
            y2 = y1;
            y1 = buf;
        }
        while (Math.abs(B - y2) > e) {
            buf = C2;
            C2 = C2 - ((Math.abs(y2 - B) * (C2 - C1)) / (Math.abs(y2 - B) - Math.abs(y1 - B)));
            C1 = buf;
            y1 = eyler(x, A, C1, h, b);
            y2 = eyler(x, A, C2, h, b);
            if (Math.abs(y2 - B) > Math.abs(y1 - B)) {
                buf = C2;
                C2 = C1;
                C1 = buf;
                buf = y2;
                y2 = y1;
                y1 = buf;
            }
        }
        show(x, A, C2, h, b);
    }
}
