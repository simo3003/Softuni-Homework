<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>

</head>
<body>
    <form>
        N: <input type="text" name="num1" />
        M: <input type="text" name="num2" />
        <input type="submit" />
    </form>
    <?php
        if(isset($_GET['num1']) && isset($_GET['num2'])) {
            $n1 = intval($_GET['num1']);
            $n2 = intval($_GET['num2']);
            echo "<ul>";
            for ($i=1; $i <= $n1; $i++) { 
                echo "<li>List $i";
                    echo "<ul>";
                for ($j=1; $j <= $n2; $j++) { 
                    echo "<li> Element $i.$j</li>";
                }
                    echo "</ul>";
                echo "</li>";
            }
            echo "</ul>";
    }
    ?>
</body>
</html>