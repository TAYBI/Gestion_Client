CREATE VIEW statistique_par_type
AS
 SELECT Type_congé, COUNT(*) as Nombre, MIN(Durée) as Minimum,  MAX(Durée) as Maximum , 
		AVG(Durée) as Moyenne, SUM(Durée) as Total
 FROM Conge
 GROUP BY Type_congé


CREATE VIEW durree_total_annee_mois
AS
 SELECT DATEPART(yy, Date_congé) as Annee, DATEPART(mm, Date_congé) as Mois, SUM(Durée) as Total
 FROM Conge
 GROUP BY DATEPART(yy, Date_congé) , DATEPART(mm, Date_congé)