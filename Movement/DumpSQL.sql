SET IDENTITY_INSERT TypesUtilisateur ON;

INSERT INTO TypesUtilisateur (Id, Type) VALUES (1, 'Standard');
INSERT INTO TypesUtilisateur (Id, Type) VALUES (2, 'Elderly');
INSERT INTO TypesUtilisateur (Id, Type) VALUES (3, 'WheelChair');
INSERT INTO TypesUtilisateur (Id, Type) VALUES (4, 'VisualyImpaired');
INSERT INTO TypesUtilisateur (Id, Type) VALUES (5, 'Maintenance');

SET IDENTITY_INSERT TypesUtilisateur OFF;


SET IDENTITY_INSERT Utilisateurs ON;

INSERT INTO Utilisateurs (Id, TypeUtilisateurId, Cle) VALUES (2, 1, '55fe061c-0a86-496e-9baf-974d4db87cb2');
INSERT INTO Utilisateurs (Id, TypeUtilisateurId, Cle) VALUES (3, 2, 'f87db164-275b-472e-82d7-772d3707bdf1');
INSERT INTO Utilisateurs (Id, TypeUtilisateurId, Cle) VALUES (4, 3, 'a65685ff-2365-4087-97b7-7f563a76663a');
INSERT INTO Utilisateurs (Id, TypeUtilisateurId, Cle) VALUES (5, 4, '0e025553-e728-4353-ba8d-c71e2fc9cb38');


SET IDENTITY_INSERT Utilisateurs OFF;

SET IDENTITY_INSERT ActionsFeu ON;

INSERT INTO ActionsFeu (Id, Type) VALUES (1, 'Demande Pieton');
INSERT INTO ActionsFeu (Id, Type) VALUES (2, 'Demande Vehicule Prioritaire');
INSERT INTO ActionsFeu (Id, Type) VALUES (3, 'Demande Construction');

SET IDENTITY_INSERT ActionsFeu OFF;

SET IDENTITY_INSERT Intersections ON;

INSERT INTO Intersections (Id, Nom) VALUES (1, 'Ormiere-Verret');

SET IDENTITY_INSERT Intersections OFF;

SET IDENTITY_INSERT Bornes ON;

INSERT INTO Bornes (Id, IntersectionID, longitude, latitude) VALUES (1,1, 46.846293, -71.372954);
INSERT INTO Bornes (Id, IntersectionID, longitude, latitude) VALUES (2,1, 46.846275, -71.372879);
INSERT INTO Bornes (Id, IntersectionID, longitude, latitude) VALUES (3,1, 46.846225, -71.372897);
INSERT INTO Bornes (Id, IntersectionID, longitude, latitude) VALUES (4,1, 46.846243, -71.372971);

SET IDENTITY_INSERT Bornes OFF;

SET IDENTITY_INSERT TypesTransport ON;

INSERT INTO TypesTransport (Id, Type) VALUES (1, 'Velo');
INSERT INTO TypesTransport (Id, Type) VALUES (2, 'Scooter');
INSERT INTO TypesTransport (Id, Type) VALUES (3, 'Moto');
INSERT INTO TypesTransport (Id, Type) VALUES (4, 'Auto');
INSERT INTO TypesTransport (Id, Type) VALUES (5, 'Van');
INSERT INTO TypesTransport (Id, Type) VALUES (6, 'Bus');
INSERT INTO TypesTransport (Id, Type) VALUES (7, 'Truck');

SET IDENTITY_INSERT TypesTransport OFF;

SET IDENTITY_INSERT Evenements ON;

insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (1, 3, 1, 1, '2021-11-30 03:54:21');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (2, 4, 1, 1, '2021-04-14 02:24:18');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (3, 2, 1, 1, '2021-09-19 20:43:31');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (4, 4, 1, 1, '2021-03-30 17:12:37');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (5, 2, 1, 1, '2022-01-19 21:08:25');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (6, 2, 1, 1, '2021-09-21 12:36:41');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (7, 2, 1, 1, '2021-04-24 02:26:17');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (8, 2, 1, 1, '2021-10-16 00:15:42');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (9, 2, 1, 1, '2022-01-23 03:46:38');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (10, 3, 1, 1, '2021-11-07 19:16:47');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (11, 2, 1, 1, '2022-01-26 04:53:41');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (12, 3, 1, 1, '2021-06-08 08:47:01');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (13, 3, 1, 1, '2021-04-23 08:58:33');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (14, 2, 1, 1, '2021-12-10 11:57:07');
--insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (15, 1, 1, 1, '2021-05-03 14:24:09');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (16, 3, 1, 1, '2021-04-11 19:53:17');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (17, 2, 1, 1, '2021-06-09 12:50:55');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (18, 3, 1, 1, '2021-08-20 19:26:50');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (19, 2, 1, 1, '2021-04-09 12:22:46');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (20, 3, 1, 1, '2021-12-17 09:20:35');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (21, 3, 1, 1, '2022-01-31 11:31:56');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (22, 2, 1, 1, '2022-01-25 10:39:26');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (23, 2, 1, 1, '2021-06-12 05:41:58');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (24, 2, 1, 1, '2021-11-29 14:38:20');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (25, 3, 1, 1, '2022-02-04 12:04:25');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (26, 3, 1, 1, '2021-12-07 01:02:57');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (27, 3, 1, 1, '2021-10-30 15:23:10');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (28, 4, 1, 1, '2021-03-14 13:44:39');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (29, 3, 1, 1, '2021-03-23 03:04:16');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (30, 2, 1, 1, '2021-10-04 06:38:02');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (31, 3, 1, 1, '2021-02-13 23:02:49');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (32, 2, 1, 1, '2021-03-01 04:28:05');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (33, 3, 1, 1, '2021-10-29 11:49:17');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (34, 2, 1, 1, '2021-11-24 22:06:16');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (35, 3, 1, 1, '2021-12-06 22:34:30');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (36, 2, 1, 1, '2021-07-07 05:42:39');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (37, 3, 1, 1, '2021-05-03 16:26:03');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (38, 3, 1, 1, '2021-08-05 21:10:42');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (39, 2, 1, 1, '2021-12-21 11:31:06');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (40, 4, 1, 1, '2021-08-01 15:21:19');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (41, 2, 1, 1, '2021-09-14 06:54:29');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (42, 3, 1, 1, '2021-12-07 15:54:27');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (43, 2, 1, 1, '2021-09-05 09:49:41');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (44, 3, 1, 1, '2021-03-24 08:28:52');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (45, 3, 1, 1, '2021-11-06 14:20:55');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (46, 2, 1, 1, '2021-09-24 15:04:46');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (47, 3, 1, 1, '2021-06-22 14:59:04');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (48, 2, 1, 1, '2021-02-24 05:33:47');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (49, 3, 1, 1, '2021-11-16 07:04:36');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (50, 2, 1, 1, '2021-10-06 06:44:56');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (51, 2, 1, 1, '2021-10-29 11:09:38');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (52, 2, 1, 1, '2021-02-16 21:46:50');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (53, 3, 1, 1, '2021-11-11 17:33:19');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (54, 3, 1, 1, '2021-03-19 19:29:37');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (55, 2, 1, 1, '2021-04-20 14:48:51');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (56, 2, 1, 1, '2021-05-08 03:53:24');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (57, 2, 1, 1, '2021-04-02 14:20:16');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (58, 4, 1, 1, '2021-04-05 03:06:08');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (59, 2, 1, 1, '2021-07-08 23:07:30');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (60, 3, 1, 1, '2021-10-22 18:09:58');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (61, 3, 1, 1, '2021-10-24 06:56:19');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (62, 2, 1, 1, '2021-08-04 19:39:24');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (63, 3, 1, 1, '2021-08-13 08:07:32');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (64, 2, 1, 1, '2021-07-12 23:49:17');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (65, 3, 1, 1, '2021-06-28 00:13:03');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (66, 2, 1, 1, '2021-09-28 02:37:10');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (67, 2, 1, 1, '2021-08-27 12:08:43');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (68, 3, 1, 1, '2021-07-25 01:15:30');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (69, 2, 1, 1, '2022-01-16 04:03:29');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (70, 2, 1, 1, '2021-11-01 13:02:02');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (71, 4, 1, 1, '2022-01-17 13:18:43');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (72, 3, 1, 1, '2021-04-06 07:26:24');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (73, 2, 1, 1, '2021-08-21 09:42:09');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (74, 3, 1, 1, '2022-01-18 17:41:01');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (75, 2, 1, 1, '2021-04-15 19:36:04');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (76, 2, 1, 1, '2021-03-15 00:56:07');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (77, 3, 1, 1, '2021-05-16 19:45:03');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (78, 3, 1, 1, '2021-04-11 19:45:41');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (79, 3, 1, 1, '2021-12-27 19:31:00');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (80, 2, 1, 1, '2021-04-07 11:58:05');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (81, 4, 1, 1, '2021-11-23 00:22:20');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (82, 3, 1, 1, '2021-10-31 14:38:52');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (83, 3, 1, 1, '2021-03-07 00:12:49');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (84, 2, 1, 1, '2021-10-10 12:43:48');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (85, 2, 1, 1, '2021-05-11 15:48:28');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (86, 3, 1, 1, '2021-05-04 03:36:40');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (87, 2, 1, 1, '2021-05-25 17:07:26');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (88, 3, 1, 1, '2021-03-08 22:58:22');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (89, 2, 1, 1, '2021-03-31 01:11:58');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (90, 2, 1, 1, '2021-11-10 19:50:02');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (91, 3, 1, 1, '2021-06-18 03:42:59');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (92, 3, 1, 1, '2021-04-15 16:39:34');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (93, 4, 1, 1, '2021-08-20 17:35:18');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (94, 2, 1, 1, '2021-12-28 14:30:45');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (95, 2, 1, 1, '2021-05-03 09:30:16');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (96, 3, 1, 1, '2021-10-13 21:49:36');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (97, 3, 1, 1, '2021-08-11 00:47:14');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (98, 2, 1, 1, '2021-06-22 07:58:12');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (99, 3, 1, 1, '2021-04-01 22:58:36');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (100, 3, 1, 1, '2022-01-23 23:10:32');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (101, 2, 1, 1, '2021-02-24 15:02:08');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (102, 3, 1, 1, '2021-11-06 19:14:24');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (103, 2, 1, 1, '2021-06-07 00:59:32');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (104, 2, 1, 1, '2021-11-01 11:53:45');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (105, 2, 1, 1, '2021-06-09 21:29:08');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (106, 3, 1, 1, '2021-06-01 08:37:02');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (107, 2, 1, 1, '2021-02-14 18:56:24');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (108, 3, 1, 1, '2021-05-01 14:39:22');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (109, 4, 1, 1, '2022-01-13 01:20:27');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (110, 3, 1, 1, '2021-09-16 03:55:27');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (111, 3, 1, 1, '2021-09-22 01:44:38');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (112, 2, 1, 1, '2021-05-29 06:29:20');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (113, 2, 1, 1, '2021-02-17 10:47:17');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (114, 3, 1, 1, '2021-12-29 11:07:48');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (115, 2, 1, 1, '2021-09-06 07:10:56');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (116, 2, 1, 1, '2021-05-04 07:07:23');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (117, 2, 1, 1, '2021-10-05 00:06:09');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (118, 2, 1, 1, '2021-04-09 21:22:32');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (119, 2, 1, 1, '2021-03-27 03:42:18');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (120, 3, 1, 1, '2021-03-14 02:56:43');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (121, 3, 1, 1, '2021-07-03 03:51:30');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (122, 2, 1, 1, '2021-11-14 06:43:57');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (123, 4, 1, 1, '2021-07-19 01:07:03');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (124, 3, 1, 1, '2021-10-07 14:44:30');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (125, 3, 1, 1, '2021-04-28 12:24:43');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (126, 2, 1, 1, '2021-07-24 09:36:20');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (127, 2, 1, 1, '2021-07-14 02:58:26');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (128, 3, 1, 1, '2021-08-24 15:07:30');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (129, 3, 1, 1, '2021-05-03 08:42:57');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (130, 2, 1, 1, '2021-02-12 08:37:25');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (131, 2, 1, 1, '2021-09-07 13:05:11');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (132, 2, 1, 1, '2021-07-29 11:54:44');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (133, 3, 1, 1, '2021-08-07 03:13:48');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (134, 3, 1, 1, '2021-08-14 06:27:40');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (135, 2, 1, 1, '2022-01-16 14:37:51');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (136, 3, 1, 1, '2021-12-26 20:37:20');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (137, 2, 1, 1, '2021-04-08 05:20:28');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (138, 3, 1, 1, '2022-01-23 00:38:39');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (139, 3, 1, 1, '2022-01-09 11:17:27');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (140, 2, 1, 1, '2022-02-08 03:19:58');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (141, 3, 1, 1, '2021-08-27 11:14:14');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (142, 3, 1, 1, '2021-08-27 09:12:30');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (143, 2, 1, 1, '2021-08-05 15:43:58');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (144, 2, 1, 1, '2022-02-01 05:38:39');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (145, 2, 1, 1, '2022-02-09 22:21:24');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (146, 4, 1, 1, '2022-01-16 10:37:22');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (147, 3, 1, 1, '2021-09-03 23:05:12');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (148, 3, 1, 1, '2021-06-05 21:16:27');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (149, 2, 1, 1, '2021-04-11 21:51:13');
insert into Evenements (id, UtilisateurId, IntersectionId, ActionId, Date) values (150, 2, 1, 1, '2021-11-19 08:29:59');

SET IDENTITY_INSERT Evenements OFF;