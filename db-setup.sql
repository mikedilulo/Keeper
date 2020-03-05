USE keeper007;

-- CREATE TABLE keeps(
--     id int AUTO_INCREMENT NOT NULL,
--     name VARCHAR(100) NOT NULL,
--     description VARCHAR(255) NOT NULL,
--     img VARCHAR(255) NOT NULL,
--     createdBy VARCHAR(100) NOT NULL,
--     timeStamp DATETIME,
--     userId VARCHAR(255),
--     isPrivate TINYINT,
--     views INT DEFAULT 0,
--     shares INT DEFAULT 0,
--     keeps INT DEFAULT 0,
--     INDEX userId(userId),
--     PRIMARY KEY (id)
-- );

-- CREATE TABLE vaults(
--     id int AUTO_INCREMENT NOT NULL,
--     name VARCHAR(100) NOT NULL,
--     description VARCHAR(255) NOT NULL,
--     img VARCHAR(255) NOT NULL,
--     views INT DEFAULT 0,
--     timeStamp DATETIME,
--     userId VARCHAR(255),
--     INDEX userId(userId),
--     PRIMARY KEY (id)
-- );

-- CREATE TABLE vaultkeeps(
--   id int AUTO_INCREMENT NOT NULL,
--   userId VARCHAR(255) NOT NULL,
--   keepId int NOT NULL,
--   vaultId int NOT NULL,
--   PRIMARY KEY (id),
--   INDEX(vaultId, keepId),
--   INDEX(userId),

--   FOREIGN KEY(vaultId)
--   REFERENCES vaults(id)
--   ON DELETE CASCADE,

--   FOREIGN KEY(keepId)
--   REFERENCES keeps(id)
--   ON DELETE CASCADE
-- );

-- SELECT * FROM keeps;
-- SELECT * FROM vaults;
-- SELECT * FROM vaultkeeps;

-- TRUNCATE TABLE keeps;
-- TRUNCATE TABLE vaults;
-- TRUNCATE TABLE vaultkeeps;

-- DROP TABLE keeps;
-- DROP TABLE vaults;
-- DROP TABLE vaultkeeps;
