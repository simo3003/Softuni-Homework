package Arrays;

import java.util.Scanner;

public class MaxSequenceOfEqualElements {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String[] input = scanner.nextLine().split(" ");

        int[] numbs = new int[input.length];
        for (int i = 0; i < input.length; i++) {
            numbs[i] = Integer.parseInt(input[i]);
        }

        int currentSeqLen = 1;
        int bestSeqLen = 0;

        int currentSeqIndex = 0;
        int bestSeqIndex = 0;

        for (int i = 1; i < numbs.length; i++) {
            if (numbs[i] != numbs[i - 1]) {
                currentSeqIndex = i;
                currentSeqLen = 1;
            } else {
                currentSeqLen++;
            }
            if (currentSeqLen > bestSeqLen) {
                bestSeqLen = currentSeqLen;
                bestSeqIndex = currentSeqIndex;
            }
        }
        for (int i = 0; i < bestSeqLen; i++) {
            System.out.print(numbs[i+bestSeqIndex] + " ");
        }
    }
}
