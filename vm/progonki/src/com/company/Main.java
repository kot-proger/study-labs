package com.company;

public class Main {

    static double funcA(double x) {
        return 1;
    }

    static double funcB(double x) {
        return 2 * x;
    }

    static double funcC(double x) {
        return 2;
    }

    static double f(double x) {
        return 4 * x;
    }

    static void pro(double a, double b, double h, double y0, double yn) {
        int n = (int) ((b - a) / h);
        double[] l = new double[n+1];
        double[] u = new double[n+1];
        double[] A = new double[n+1];
        double[] B = new double[n+1];
        double[] C = new double[n+1];
        double[] G = new double[n+1];
        double[] Y = new double[n+1];
        double xi = a + h;


        for (int i = 1; i < n; i++) {
            A[i] = funcA(xi);
            B[i] = funcC(xi) * h * h - funcB(xi) * h - 2 * funcA(xi);
            C[i] = funcA(xi) + funcB(xi) * h;
            G[i] = f(xi) * h * h;
            xi += h;
        }

        l[0] = 0;
        u[0] = y0;

        for (int i = 1; i < n; i++) {
            l[i] = (-C[i]) / (A[i] * l[i - 1] + B[i]);
            u[i] = (G[i] - A[i] * u[i - 1]) / (A[i] * l[i - 1] + B[i]);
        }

        Y[0] = y0;
        Y[n] = yn;

        for (int i = n - 1; i >= 1; i--) {
            Y[i] = l[i] * Y[i + 1] + u[i];
        }

        xi = a;
        for (int i = 0; i < n+1; i++) {
            System.out.println(xi + "  " + Y[i]);
            xi += h;
        }
    }

    public static void main(String[] args) {
        double h = 0.05;
        double y0 = 0, yn = 1.279;
        double a = 0, b = 0.5;
        pro(a, b, h, y0, yn);
    }
}
// Ay`` + By` + Cy = f