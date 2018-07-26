package StringsMapsStreamAPI;

import java.util.Scanner;

public class URLParser {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String input = scanner.nextLine();

        String protocol = "";
        String server = "";
        String res = "";

        int index = input.indexOf("://");
        if (index != -1) {
            protocol  = input.substring(0, index);
            input = input.substring(index + 3);
            index = input.indexOf("/");
            if (index != -1) {
                server = input.substring(0, index);
                input = input.substring(index + 1);
                res = input;
            } else {
                server = input;
            }
        } else {
            index = input.indexOf("/");
            if (index != -1) {
                server = input.substring(0, index);
                input = input.substring(index + 1);
                res = input;
            } else {
                server = input;
            }
        }

        System.out.printf("[protocol] = \"%s\"", protocol);
        System.out.println();
        System.out.printf("[server] = \"%s\"", server);
        System.out.println();
        System.out.printf("[resource] = \"%s\"", res);
    }
}
