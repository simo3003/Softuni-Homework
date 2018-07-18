<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>
    <style>
        div {
            display: inline-block;
            margin: 5px;
            width: 20px;
            height: 20px;
        }
    </style> 
</head>
<body>
<?php
for ($i=0; $i <= 255; $i+=51) { 
    $color = "rgb($i,$i,$i)";
        echo "<div style=background-color:$color></div>\n";
            for ($j=1; $j < 10; $j++) { 
                $temp = $i+$j*5;
                $innerColor = "rgb($temp,$temp,$temp)";
                echo "<div style=background-color:$innerColor></div>\n";
            }
        echo "<br>";
}
?>
</body>
</html>