<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>
	<style>
		table * {
			border: 1px solid black;
			width: 50px;
			height: 50px;
		}
    </style>
</head>
<body>
<table>
    <tr>
        <td>
            Red
        </td>
        <td>
            Green
        </td>
        <td>
            Blue
        </td>
    </tr>
    <?php
    $num = 51;
    $color = "rgb($num,0,0)";
    
    for ($i=0; $i < 5; $i++) { 

        echo "<tr>";
            echo "<td style=background-color:$color></td>";
             $color = "rgb(0,$num,0)";
            echo "<td style=background-color:$color></td>";
             $color = "rgb(0,0,$num)";
            echo "<td style=background-color:$color></td>";
        echo "</tr>";

        $num+=51;
        $color = "rgb($num,0,0)";
    }
    ?>
</table>
</body>
</html>