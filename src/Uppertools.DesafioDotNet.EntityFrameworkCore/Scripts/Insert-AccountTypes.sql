SET IDENTITY_INSERT AccountTypes ON;

INSERT INTO AccountTypes (Id, [Description]) VALUES
  (1, 'Água'),
  (2, 'Energia'),
  (3, 'Taxi'),
  (4, 'Locação de veículos'),
  (5, 'Hospedagem de Funcionário');

SET IDENTITY_INSERT AccountTypes OFF;