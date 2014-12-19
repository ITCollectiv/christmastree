(loop[x 0] (when(< x 10) (println(repeat x "*"))(recur(+ x 1))))
