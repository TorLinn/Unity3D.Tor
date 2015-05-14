<?php
include_once 'connectdb.php';
if(isset($_POST['name'])&&isset($_POST['x'])&&isset($_POST['y'])&&isset($_POST['z'])&&isset($_POST['rx'])&&isset($_POST['ry'])&&isset($_POST['rz'])&&isset($_POST['rw'])){
    $name=$_POST['name'];
    $x=(float) $_POST['x'];
    $y=(float) $_POST['y'];
    $z=(float) $_POST['z'];
    $rx=(float) $_POST['rx'];
    $ry=(float) $_POST['ry'];
    $rz=(float) $_POST['rz'];
    $rw=(float) $_POST['rw']; 
    $str=  "INSERT INTO `kubik_poss`(`name`,`x`,`y`,`z`,`rx`,`ry`,`rz`,`rw`) VALUES ('$name','$x','$y','$z','$rx','$ry','$rz','$rw')";
    echo $str;
    mysql_query($str);
}
else{
echo "error 1";
}
?>
