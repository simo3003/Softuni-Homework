<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>

</head>
<body>
    <form>
        N: <input type="text" name="num" />
        <input type="submit" />
    </form>
    <?php
    if(isset($_GET['num'])) {
        $n = intval($_GET['num']);
        $fib = [1,1,2];
        echo "1 1 2 ";
        for ($i=2; $i <= $n; $i++) { 
            $fib[] = $fib[$i] + $fib[$i-1] + $fib[$i-2];
            echo $fib[$i+1] . " ";
        }
    }
    ?>
</body>
</html>