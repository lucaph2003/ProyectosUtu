CREATE DATABASE the_big_four;

DROP TABLE IF EXISTS the_big_four.`administrador`;
CREATE TABLE the_big_four.`administrador` (
  `idadmin` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(45) NOT NULL,
  `apellido` varchar(45) NOT NULL,
  `password` varchar(45) NOT NULL,
  `ci` varchar(9) NOT NULL,
  `fotoperfil` longblob,
  PRIMARY KEY (`idadmin`)
) ;

DROP TABLE IF EXISTS the_big_four.`alumnos`;
CREATE TABLE the_big_four.`alumnos` (
  `idalumno` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(45) NOT NULL,
  `apellido` varchar(45) NOT NULL,
  `password` varchar(45) NOT NULL,
  `ci` varchar(9) NOT NULL,
  `fotoperfil` longblob,
  `conexion` datetime DEFAULT NULL,
  PRIMARY KEY (`idalumno`)
) ;

DROP TABLE IF EXISTS the_big_four.`asignatura`;
CREATE TABLE the_big_four.`asignatura` (
  `idasignatura` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) NOT NULL,
  `cantidadhoras` int NOT NULL,
  PRIMARY KEY (`idasignatura`)
);

DROP TABLE IF EXISTS the_big_four.`chat`;
CREATE TABLE the_big_four.`chat` (
  `idchat` int NOT NULL AUTO_INCREMENT,
  `idremitente` int NOT NULL,
  `idreceptor` int NOT NULL,
  `mensaje` varchar(400) NOT NULL,
  `fechamensaje` datetime NOT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`idchat`)
) ;

DROP TABLE IF EXISTS the_big_four.`grupos`;
CREATE TABLE the_big_four.`grupos` (
  `idgrupo` int NOT NULL AUTO_INCREMENT,
  `idorientacion` int NOT NULL,
  `turno` varchar(45) NOT NULL,
  `Grado` int NOT NULL,
  `Nombre` varchar(45) NOT NULL,
  PRIMARY KEY (`idgrupo`)
) ;

DROP TABLE IF EXISTS the_big_four.`orientaciones`;
CREATE TABLE the_big_four.`orientaciones` (
  `idorientaciones` int NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(45) NOT NULL,
  PRIMARY KEY (`idorientaciones`)
) ;

DROP TABLE IF EXISTS the_big_four.`alumnos_grupo`;
CREATE TABLE the_big_four.`alumnos_grupo` (
  `idgrupo` int NOT NULL,
  `idalumno` int NOT NULL,
  PRIMARY KEY (`idgrupo`,`idalumno`),
  KEY `fk_alumno_idx` (`idalumno`),
  CONSTRAINT `fk_alumno` FOREIGN KEY (`idalumno`) REFERENCES `alumnos` (`idalumno`),
  CONSTRAINT `fk_grupo` FOREIGN KEY (`idgrupo`) REFERENCES `grupos` (`idgrupo`)
);

DROP TABLE IF EXISTS the_big_four.`asignaturas_orientacion`;
CREATE TABLE the_big_four.`asignaturas_orientacion` (
  `idorientaciones` int NOT NULL,
  `idasignatura` int NOT NULL,
  PRIMARY KEY (`idorientaciones`,`idasignatura`),
  KEY `fk_asignaturas_idx` (`idasignatura`),
  CONSTRAINT `fk_asignaturas` FOREIGN KEY (`idasignatura`) REFERENCES `asignatura` (`idasignatura`),
  CONSTRAINT `fk_orientaciones` FOREIGN KEY (`idorientaciones`) REFERENCES `orientaciones` (`idorientaciones`)
);

DROP TABLE IF EXISTS the_big_four.`chat_sala`;
CREATE TABLE the_big_four.`chat_sala` (
  `idchat_sala` int NOT NULL AUTO_INCREMENT,
  `mensaje` varchar(45) NOT NULL,
  `fechamensaje` datetime NOT NULL,
  `idremitente` int NOT NULL,
  `idgrupo` int NOT NULL,
  PRIMARY KEY (`idchat_sala`),
  KEY `idgrupo_idx` (`idgrupo`),
  CONSTRAINT `idgrupo` FOREIGN KEY (`idgrupo`) REFERENCES `grupos` (`idgrupo`)
) ;

DROP TABLE IF EXISTS the_big_four.`chatdocentes`;
CREATE TABLE the_big_four.`chatdocentes` (
  `idchat` int NOT NULL AUTO_INCREMENT,
  `idremitente` int NOT NULL,
  `idreceptor` int NOT NULL,
  `mensaje` varchar(400) NOT NULL,
  `fechamensaje` datetime NOT NULL,
  `estado` tinyint(1) NOT NULL,
  PRIMARY KEY (`idchat`)
) ;

DROP TABLE IF EXISTS the_big_four.`docentes`;
CREATE TABLE the_big_four.`docentes` (
  `iddocente` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(45) NOT NULL,
  `apellido` varchar(45) NOT NULL,
  `password` varchar(45) NOT NULL,
  `ci` varchar(9) NOT NULL,
  `fotoperfil` longblob,
  `idasignatura` int ,
  `conexion` DATETIME ,
  PRIMARY KEY (`iddocente`),
  KEY `asignatura_idx` (`idasignatura`),
  CONSTRAINT `fk_docente_asignatura` FOREIGN KEY (`idasignatura`) REFERENCES `asignatura` (`idasignatura`)
);

INSERT INTO `the_big_four`.`administrador` (`nombre`, `apellido`, `password`, `ci`) VALUES ('Nicolas', 'Rico', '6', '46222982');
INSERT INTO `the_big_four`.`administrador` (`nombre`, `apellido`, `password`, `ci`) VALUES ('Roberto', 'Manso', '7', '23226973');
INSERT INTO `the_big_four`.`administrador` (`nombre`, `apellido`, `password`, `ci`) VALUES ('Martin', 'Gonzalez', '8', '33556974');
INSERT INTO `the_big_four`.`administrador` (`nombre`, `apellido`, `password`, `ci`) VALUES ('Rino', 'Martinez', '9', '78999873');
INSERT INTO `the_big_four`.`administrador` (`nombre`, `apellido`, `password`, `ci`) VALUES ('Lucas', 'Rosa', '10', '58900972');

INSERT INTO `the_big_four`.`alumnos` (`nombre`, `apellido`, `password`, `ci`) VALUES ('Edgar', 'Romario', '2', '5222983');
INSERT INTO `the_big_four`.`alumnos` (`nombre`, `apellido`, `password`, `ci`) VALUES ('Ronald', 'Rooney', '3', '34246783');
INSERT INTO `the_big_four`.`alumnos` (`nombre`, `apellido`, `password`, `ci`) VALUES ('Nicolas', 'Roberts', '4', '22222222');
INSERT INTO `the_big_four`.`alumnos` (`nombre`, `apellido`, `password`, `ci`) VALUES ('Luka', 'Luma', '5', '33333333');
INSERT INTO `the_big_four`.`alumnos` (`nombre`, `apellido`, `password`, `ci`) VALUES ('Roman', 'Riquelme', '6', '11111111');

INSERT INTO `the_big_four`.`asignatura` (`idasignatura`, `nombre`, `cantidadhoras`) VALUES ('3', 'Matematicas', '6');
INSERT INTO `the_big_four`.`asignatura` (`idasignatura`, `nombre`, `cantidadhoras`) VALUES ('4', 'Programacion', '3');
INSERT INTO `the_big_four`.`asignatura` (`idasignatura`, `nombre`, `cantidadhoras`) VALUES ('5', 'Sistemas Operativos', '3');
INSERT INTO `the_big_four`.`asignatura` (`idasignatura`, `nombre`, `cantidadhoras`) VALUES ('6', 'Ingles', '3');
INSERT INTO `the_big_four`.`asignatura` (`idasignatura`, `nombre`, `cantidadhoras`) VALUES ('7', 'Formacion empresarial', '3');

INSERT INTO `the_big_four`.`docentes` (`nombre`, `apellido`, `password`, `ci`, `idasignatura`) VALUES ('Martin', 'Volador', '21', '67555239', '3');
INSERT INTO `the_big_four`.`docentes` (`nombre`, `apellido`, `password`, `ci`, `idasignatura`) VALUES ('Roman', 'Ramirez', '35', '54333289', '3');
INSERT INTO `the_big_four`.`docentes` (`nombre`, `apellido`, `password`, `ci`, `idasignatura`) VALUES ('Lara', 'Nuñez', '555', '43222764', '5');
INSERT INTO `the_big_four`.`docentes` (`nombre`, `apellido`, `password`, `ci`, `idasignatura`) VALUES ('Sara', 'Nicoletti', '4232', '43999872', '3');
INSERT INTO `the_big_four`.`docentes` (`nombre`, `apellido`, `password`, `ci`, `idasignatura`) VALUES ('Robert', 'Sumiso', '223', '38777451', '7');

INSERT INTO `the_big_four`.`chat` (`idremitente`, `idreceptor`, `mensaje`, `fechamensaje`, `estado`) VALUES ('2', '1', 'Buenas', '2021-11-03 19:45:50', '1');
INSERT INTO `the_big_four`.`chat` (`idremitente`, `idreceptor`, `mensaje`, `fechamensaje`, `estado`) VALUES ('2', '1', 'Chau', '2021-11-03 20:45:50', '1');
INSERT INTO `the_big_four`.`chat` (`idremitente`, `idreceptor`, `mensaje`, `fechamensaje`, `estado`) VALUES ('2', '1', 'Dios existe', '2021-11-03 20:45:55', '1');
INSERT INTO `the_big_four`.`chat` (`idremitente`, `idreceptor`, `mensaje`, `fechamensaje`, `estado`) VALUES ('2', '1', 'Todo bien', '2021-11-03 16:45:50', '1');
INSERT INTO `the_big_four`.`chat` (`idremitente`, `idreceptor`, `mensaje`, `fechamensaje`, `estado`) VALUES ('2', '1', 'Todo mal', '2021-11-03 20:45:50', '1');

INSERT INTO `the_big_four`.`orientaciones` (`Nombre`) VALUES ('Informatica');
INSERT INTO `the_big_four`.`orientaciones` (`Nombre`) VALUES ('Soporte');
INSERT INTO `the_big_four`.`orientaciones` (`Nombre`) VALUES ('Web');
INSERT INTO `the_big_four`.`orientaciones` (`Nombre`) VALUES ('Videojuegos');
INSERT INTO `the_big_four`.`orientaciones` (`Nombre`) VALUES ('Robotica');

INSERT INTO `the_big_four`.`grupos` (`idorientacion`, `turno`, `Grado`, `Nombre`) VALUES ('1', 'Matutino', '3', '3BA');
INSERT INTO `the_big_four`.`grupos` (`idorientacion`, `turno`, `Grado`, `Nombre`) VALUES ('2', 'Vespertino', '2', '2BJ');
INSERT INTO `the_big_four`.`grupos` (`idorientacion`, `turno`, `Grado`, `Nombre`) VALUES ('1', 'Nocturno', '1', '1BE');
INSERT INTO `the_big_four`.`grupos` (`idorientacion`, `turno`, `Grado`, `Nombre`) VALUES ('3', 'Matutino', '3', '3BA1');
INSERT INTO `the_big_four`.`grupos` (`idorientacion`, `turno`, `Grado`, `Nombre`) VALUES ('2', 'Vespertino', '2', '2BC');
