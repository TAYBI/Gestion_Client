CREATE VIEW statistique_par_type
AS
 SELECT Type_congé, COUNT(*) as Nombre, MIN(Durée) as Minimum,  MAX(Durée) as Maximum , 
		AVG(Durée) as Moyenne, SUM(Durée) as Total
 FROM Conge
 GROUP BY Type_congé



SELECT * FROM statistique_par_type