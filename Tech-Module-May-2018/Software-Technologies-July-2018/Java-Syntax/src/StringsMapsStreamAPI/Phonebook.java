package StringsMapsStreamAPI;

import java.util.LinkedHashMap;
import java.util.Map;
import java.util.Scanner;
import java.util.TreeMap;

public class Phonebook {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String input = scanner.nextLine();
        Map<String, String> phonebook = new TreeMap<>();
        while (!input.equals("END")) {
            String[] parameters = input.split(" ");
            switch (parameters[0]) {
                case "A":
                    if (phonebook.containsKey(parameters[1])) {
                        phonebook.put(parameters[1], parameters[2]);
                    } else {
                        phonebook.put(parameters[1], parameters[2]);
                    }
                    break;
                case "S":
                    if (phonebook.containsKey(parameters[1])) {
                        System.out.printf("%s -> %s", parameters[1], phonebook.get(parameters[1]));
                        System.out.println();
                    } else {
                        System.out.printf("Contact %s does not exist.", parameters[1]);
                        System.out.println();
                    }
                    break;
                case "ListAll":
                    for (String key : phonebook.keySet()) {
                        System.out.printf("%s -> %s", key, phonebook.get(key));
                        System.out.println();
                    }
                    break;
            }
            input = scanner.nextLine();
        }
    }
}
