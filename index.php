<!DOCTYPE html>
<html lang="es">
	<head>
		<meta charset="UTF-8">
		<meta name="viewport" content="width=device-width, user-scalable=no, initial-scale=1, maximum-scale=1, minimum-scale=1">
		<title>project name</title>
	</head>
	<body>
		<table>
			<tr>
				<td>Numeros</td>
			</tr>
			<?php
			for($val=1; $val <= 10; $val++){
			?>
			<tr>
				<td><?php echo $val ?></td>
			</tr>
			<?php
			}
			?>
		</table>
	</body>
</html>