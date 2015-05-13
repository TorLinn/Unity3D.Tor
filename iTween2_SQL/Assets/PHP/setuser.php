<?php
include_once 'conect.php';
if(isset($_POST['name'])&&isset($_POST['level'])&&isset($_POST['score'])){
    $name= mysql_escape_string($_POST['name']);
    $level=(int) $_POST['level'];
    $score=(int) $_POST['score'];    
    mysql_query("INSERT INTO `players`(`name`, `level`, `score`) VALUES ('$name',$level,$score)");
}
else{
echo "error 1";
}
?>
