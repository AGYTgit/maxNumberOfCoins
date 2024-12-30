using System;
using System.Collections.Generic;

class Program {
    static int MaxCoinsCollected(int[][] board) {
        int n = board.Length;
        int m = board[0].Length;

        int[,] dp = new int[n, m];

        dp[0, 0] = board[0][0];

        for (int j = 1; j < m; j++) {
            dp[0, j] = dp[0, j - 1] + board[0][j];
        }

        for (int i = 1; i < n; i++) {
            dp[i, 0] = dp[i - 1, 0] + board[i][0];
        }

        for (int i = 1; i < n; i++) {
            for (int j = 1; j < m; j++) {
                dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]) + board[i][j];
            }
        }

        return dp[n - 1, m - 1];
    }

    static void Main() {
        int[][] board1 = {
            new int[] {1, 0, 1, 0, 1},
            new int[] {1, 1, 0, 0, 0},
            new int[] {0, 1, 1, 0, 1},
            new int[] {1, 0, 1, 1, 0}
        };

        int[][] board2 = {
            new int[] {0, 0, 0, 0, 1, 0, 1, 0, 0, 1},
            new int[] {1, 0, 1, 0, 0, 0, 0, 0, 0, 0},
            new int[] {0, 1, 0, 0, 1, 0, 0, 0, 1, 1},
            new int[] {0, 1, 1, 1, 0, 1, 1, 0, 0, 1},
            new int[] {1, 1, 1, 0, 0, 1, 1, 1, 1, 0},
            new int[] {0, 1, 0, 0, 0, 0, 1, 1, 1, 1},
            new int[] {0, 0, 1, 1, 1, 1, 0, 1, 1, 0},
            new int[] {1, 1, 1, 0, 0, 1, 1, 1, 1, 1},
            new int[] {1, 1, 0, 0, 0, 0, 1, 1, 0, 1},
            new int[] {0, 0, 0, 0, 1, 1, 0, 0, 0, 1},
            new int[] {1, 1, 1, 0, 1, 1, 1, 1, 0, 0},
            new int[] {0, 1, 1, 0, 1, 0, 1, 0, 0, 1},
            new int[] {1, 0, 1, 1, 1, 1, 0, 0, 1, 0},
            new int[] {1, 1, 1, 1, 0, 1, 1, 1, 1, 1},
            new int[] {0, 0, 1, 0, 0, 1, 0, 0, 1, 0},
            new int[] {1, 0, 1, 1, 0, 1, 0, 1, 0, 1},
            new int[] {0, 1, 0, 0, 0, 1, 1, 1, 1, 0},
            new int[] {1, 0, 1, 1, 0, 0, 1, 0, 1, 1},
            new int[] {1, 1, 1, 0, 1, 1, 0, 1, 1, 1},
            new int[] {0, 0, 0, 1, 1, 0, 1, 1, 0, 0},
            new int[] {0, 0, 0, 0, 1, 0, 1, 0, 1, 1},
            new int[] {1, 0, 0, 1, 1, 1, 0, 1, 0, 0},
            new int[] {1, 0, 1, 1, 0, 0, 1, 0, 0, 1},
            new int[] {1, 1, 0, 1, 1, 0, 1, 1, 0, 0},
            new int[] {1, 0, 1, 0, 0, 1, 1, 1, 0, 1},
            new int[] {1, 1, 0, 1, 1, 0, 0, 0, 0, 1}
        };

        Console.WriteLine(MaxCoinsCollected(board1));
        Console.WriteLine(MaxCoinsCollected(board2));
    }
}
