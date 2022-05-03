CREATE TABLE [user] (
    user_id int IDENTITY(1,1) NOT NULL,
    username varchar(100) NOT NULL,
    password_hash varchar(200) NOT NULL,
    salt varchar(200) NOT NULL,
    CONSTRAINT PK_user PRIMARY KEY (user_id)
);