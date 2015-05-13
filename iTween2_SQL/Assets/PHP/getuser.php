<?php
include_once 'conect.php';
 $query = mysql_query("SELECT `name`, `level`, `score` FROM `players`");
while(($row=mysql_fetch_array($query))){
$rows[]=$row;
}
echo json_encode($rows);
?>