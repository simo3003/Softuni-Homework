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
            $output = "";
            for ($i=1; $i <= $_GET['num']; $i++) { 
                $output = $output . " " .strval($i);
            }
            echo $output;
        }
    ?>
</body>
</html>