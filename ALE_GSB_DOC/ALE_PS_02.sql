
/*Création des procédures stockées pour la fonctionnalité consultation des praticiens*/

USE BBLLGSB
GO

CREATE PROC PSS_ListeMedic AS
/*Retourne la liste des médicament offert aux praticiens*/
SELECT MED_DEPOTLEGAL, MED_NOMCOMMERCIAL, MED_COMPOSITION, MED_EFFETS, MED_CONTREINDIC
FROM MEDICAMENT
WHERE MED_DEPOTLEGAL IN(SELECT DISTINCT MED_DEPOTLEGAL FROM OFFRIR)

GO

CREATE PROC PSS_NombreMedic AS
/*Retourne le nombre de médicament offert aux praticiens*/
SELECT COUNT(*) AS 'Nombre de médicaments'
FROM MEDICAMENT
WHERE MED_DEPOTLEGAL IN(SELECT MED_DEPOTLEGAL FROM OFFRIR)

go

CREATE PROC PSS_ListePraMedic @idmedic VARCHAR(50) AS
/*Retourne la liste des praticien qui ce sont vu offrir le medicament envoyé*/
SELECT P.PRA_NUM, PRA_NOM, PRA_PRENOM, SUM(OFF_QTE) AS 'Quantitée vendu'
FROM OFFRIR O 
INNER JOIN RAPPORT_VISITE RV ON O.RAP_NUM = RV.RAP_NUM
INNER JOIN PRATICIEN P ON RV.PRA_NUM = P.PRA_NUM
WHERE MED_DEPOTLEGAL = @idmedic
GROUP BY P.PRA_NUM, PRA_NOM, PRA_PRENOM

/*Création des procédures stockées pour la fonctionnalité consultation des praticiens*/

GO

CREATE PROC PSS_ListePraticien AS
/*Retourne la liste des praticiens*/
SELECT PRA_NUM, PRA_NOM, PRA_PRENOM, TYP_LIBELLE
FROM PRATICIEN P INNER JOIN TYPE_PRATICIEN TP ON P.TYP_CODE = TP.TYP_CODE
ORDER BY PRA_NOM ASC

GO

CREATE PROC PSS_DetailPraticien @id INT AS
/*Retourne les informations d'un praticiens selectionné*/
SELECT PRA_NOM, PRA_PRENOM, PRA_ADRESSE, PRA_VILLE, PRA_CP, TYP_LIBELLE, TYP_LIEU
FROM PRATICIEN P INNER JOIN TYPE_PRATICIEN TP ON P.TYP_CODE = TP.TYP_CODE
WHERE PRA_NUM = @id

GO

CREATE PROC PSS_NombrePraticien AS
/*Retourne le nombre de praticien*/
SELECT COUNT(*) as 'Nombre de praticien' FROM PRATICIEN