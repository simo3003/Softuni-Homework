package ClassesAndObjects;

import java.util.Random;
import java.util.Scanner;

public class AdvertisementMessage {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int n = Integer.parseInt(scanner.nextLine());

        for (int i = 1; i <= n; i++) {
            Message msg = new Message();
            System.out.println(msg.getMessage());
        }
    }
}

class Message {
    private String[] Phrases =
            {
                    "Excellent product.",
                    "Such a great product.",
                    "I always use that product.",
                    "Best product of its category.",
                    "Exceptional product.",
                    "I can’t live without this product."
            };

    private String[] Events =
            {
                    "Now I feel good.",
                    "I have succeeded with this product.",
                    "Makes miracles. I am happy of the results!",
                    "I cannot believe but now I feel awesome.",
                    "Try it yourself, I am very satisfied.",
                    "I feel great!"
            };
    private String[] Authors =
            {
                    "Diana",
                    "Petya",
                    "Stella",
                    "Elena",
                    "Katya",
                    "Annie",
                    "Eva"
            };
    private String[] Cities =
            {
                    "Burgas",
                    "Sofia",
                    "Plovdiv",
                    "Varna",
                    "Ruse"
            };
    public String FinishedMessage;
    private Random rndm;

    public Message() {
        rndm = new Random();
        rndm.nextInt();
        String msgPhrase = Phrases[rndm.nextInt(Phrases.length)];
        String msgEvents = Events[rndm.nextInt(Events.length)];
        String msgAuthor = Authors[rndm.nextInt(Authors.length)];
        String msgCity = Cities[rndm.nextInt(Cities.length)];
        this.FinishedMessage = String.format("%s %s %s - %s", msgPhrase, msgEvents, msgAuthor, msgCity);
    }
    public String getMessage() {
        return this.FinishedMessage;
    }
}
