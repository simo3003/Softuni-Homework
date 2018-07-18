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
        $fib = [1,1];
        echo "1 1 ";
        for ($i=1; $i <= $n; $i++) { 
            $fib[] = $fib[$i] + $fib[$i-1];
            echo $fib[$i+1] . " ";
        }
    }
    ?>
</body>
</html>