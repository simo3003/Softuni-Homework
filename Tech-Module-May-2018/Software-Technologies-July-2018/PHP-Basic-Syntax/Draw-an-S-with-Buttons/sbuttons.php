<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>

</head>
<body>
    <?php
    $on = '<button style="background-color: blue">1</button>';
    $off = '<button>0</button>';
    for ($i=1; $i <= 9; $i++) { 
        switch ($i) {
            case 1:
            case 5:
            case 9:
            if($i == 5 || $i == 9) {
                echo "<br>";
            }
            for ($j=0; $j < 5; $j++) { 
                echo $on;
            }
                break;
            case 2:
            case 3:
            case 4:
            echo "<br>";
            echo $on;
            for ($j=1; $j < 5; $j++) { 
                echo $off;
            }
                break;
            case 6:
            case 7:
            case 8:
            echo "<br>";
            for ($j=1; $j < 5; $j++) { 
                echo $off;
            }
            echo $on;
                break;   
        }
    }
    ?>
</body>
</html>