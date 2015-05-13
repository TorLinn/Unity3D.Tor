<?php
include_once 'connectdb.php';
if(isset($_POST['x'])&&isset($_POST['y'])&&isset($_POST['z'])&&isset($_POST['rx'])&&isset($_POST['ry'])&&isset($_POST['rz'])&&isset($_POST['rw'])){
    $x=(float) $_POST['x'];
    $y=(float) $_POST['y'];
    $z=(float) $_POST['z'];
    $rx=(float) $_POST['rx'];
    $ry=(float) $_POST['ry'];
    $rz=(float) $_POST['rz'];
    $rw=(float) $_POST['rw']; 
    $str=  "INSERT INTO `kubik_pos`('x','y','z','rx','ry','rz','rw') VALUES ($x,$y,$z,$rx,$ry,$rz,$rw)";
    echo $str;
    mysql_query("INSERT INTO `kubik_pos`('x','y','z','rx','ry','rz','rw') VALUES ($x,$y,$z,$rx,$ry,$rz,$rw)");
}
else{
echo "error 1";
}
?>
