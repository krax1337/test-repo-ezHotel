using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ezHotel
{
    class QueryHolder
    {
        public static string InitQuery = @"
CREATE TABLE Client (
	client_id	INTEGER NOT NULL UNIQUE,
	first_name	TEXT NOT NULL,
	last_name	TEXT NOT NULL,
	phone	TEXT NOT NULL,
	email TEXT NOT NULL,
	country	TEXT NOT NULL,
	passport_number	TEXT NOT NULL,
	CONSTRAINT pk_Client PRIMARY KEY(client_id AUTOINCREMENT)
);

CREATE TABLE RoomType (
	room_type_id	INTEGER NOT NULL UNIQUE,
	name TEXT NOT NULL,
	number_of_beds	INTEGER NOT NULL,
	price	INTEGER NOT NULL,
	CONSTRAINT pk_RoomType PRIMARY KEY(room_type_id AUTOINCREMENT)
);

CREATE TABLE Room (
	room_id	INTEGER NOT NULL UNIQUE,
	floor	INTEGER NOT NULL,
	room_type_id	INTEGER NOT NULL,
	occupied INTEGER DEFAULT 0,
	CONSTRAINT pk_Room PRIMARY KEY(room_id AUTOINCREMENT),
	CONSTRAINT fk_RoomType FOREIGN KEY(room_type_id) REFERENCES RoomType(room_type_id)
);

CREATE TABLE Reservation (
	reservation_id	INTEGER NOT NULL UNIQUE,
	room_id	INTEGER NOT NULL,
	client_id	INTEGER NOT NULL,
	start_date TEXT NOT NULL,
	end_date TEXT NOT NULL,
	current_status TEXT,
	amount INTEGER,
	CONSTRAINT pk_Reservation PRIMARY KEY(reservation_id AUTOINCREMENT),
	CONSTRAINT fk_Room FOREIGN KEY(room_id) REFERENCES Room(room_id)
	CONSTRAINT fk_Client FOREIGN KEY(client_id) REFERENCES Client(client_id)
);

insert into Client (first_name, last_name, phone, email, country, passport_number) values ('Gray', 'Piggens', '691-351-2558', 'gpiggens0@ebay.com', 'Serbia', '058713330-9');
insert into Client (first_name, last_name, phone, email, country, passport_number) values ('Deerdre', 'Dohr', '758-938-8762', 'ddohr1@creativecommons.org', 'Germany', '424165064-3');
insert into Client (first_name, last_name, phone, email, country, passport_number) values ('Tiebold', 'Ourry', '252-355-6685', 'tourry2@hugedomains.com', 'Mongolia', '716757509-7');
insert into Client (first_name, last_name, phone, email, country, passport_number) values ('Sherwood', 'Maharg', '866-572-1986', 'smaharg3@networkadvertising.org', 'Brazil', '626885973-1');
insert into Client (first_name, last_name, phone, email, country, passport_number) values ('Granthem', 'O''Duggan', '686-919-1211', 'goduggan4@home.pl', 'Philippines', '477673889-9');
insert into Client (first_name, last_name, phone, email, country, passport_number) values ('Alaster', 'Lote', '469-834-6833', 'alote5@europa.eu', 'Japan', '071290316-X');
insert into Client (first_name, last_name, phone, email, country, passport_number) values ('Sonya', 'Stud', '168-870-2084', 'sstud6@mozilla.com', 'China', '147401278-7');
insert into Client (first_name, last_name, phone, email, country, passport_number) values ('Claudell', 'Brewin', '408-546-7120', 'cbrewin7@ocn.ne.jp', 'Portugal', '517160198-4');
insert into Client (first_name, last_name, phone, email, country, passport_number) values ('Chrissie', 'Rowbottom', '981-269-5418', 'crowbottom8@npr.org', 'Nigeria', '659287144-X');
insert into Client (first_name, last_name, phone, email, country, passport_number) values ('Baillie', 'Trustram', '843-276-7260', 'btrustram9@barnesandnoble.com', 'Indonesia', '419162939-5');
insert into Client (first_name, last_name, phone, email, country, passport_number) values ('Grady', 'Vivyan', '720-407-8414', 'gvivyana@wired.com', 'Dominican Republic', '044283409-8');
insert into Client (first_name, last_name, phone, email, country, passport_number) values ('Carson', 'Condy', '352-517-2854', 'ccondyb@twitpic.com', 'Kenya', '334407367-2');
insert into Client (first_name, last_name, phone, email, country, passport_number) values ('Anissa', 'Brogioni', '211-841-9784', 'abrogionic@altervista.org', 'China', '252372241-0');
insert into Client (first_name, last_name, phone, email, country, passport_number) values ('Nona', 'Enrigo', '900-139-4667', 'nenrigod@utexas.edu', 'Thailand', '612842972-6');
insert into Client (first_name, last_name, phone, email, country, passport_number) values ('Alwyn', 'Hethron', '313-247-1976', 'ahethrone@oaic.gov.au', 'Poland', '033444411-X');
insert into Client (first_name, last_name, phone, email, country, passport_number) values ('Rochette', 'Weatherburn', '542-432-5024', 'rweatherburnf@addthis.com', 'Zambia', '813695089-X');
insert into Client (first_name, last_name, phone, email, country, passport_number) values ('Aidan', 'Geany', '407-732-2472', 'ageanyg@geocities.jp', 'China', '727512729-6');
insert into Client (first_name, last_name, phone, email, country, passport_number) values ('Sherman', 'Costain', '114-726-8727', 'scostainh@engadget.com', 'China', '500253411-2');
insert into Client (first_name, last_name, phone, email, country, passport_number) values ('Lydon', 'Matthessen', '501-977-1198', 'lmatthesseni@independent.co.uk', 'Philippines', '771976439-0');
insert into Client (first_name, last_name, phone, email, country, passport_number) values ('Collen', 'Hefner', '392-500-0120', 'chefnerj@eventbrite.com', 'France', '766478925-7');
insert into Client (first_name, last_name, phone, email, country, passport_number) values ('Corette', 'Ethington', '639-969-9914', 'cethingtonk@ox.ac.uk', 'China', '587020176-4');
insert into Client (first_name, last_name, phone, email, country, passport_number) values ('Crawford', 'Reiners', '629-372-6046', 'creinersl@netlog.com', 'Cameroon', '382636515-1');
insert into Client (first_name, last_name, phone, email, country, passport_number) values ('Alisun', 'Casillis', '834-421-7087', 'acasillism@independent.co.uk', 'Bosnia and Herzegovina', '686908830-6');
insert into Client (first_name, last_name, phone, email, country, passport_number) values ('Ansel', 'McArthur', '150-557-9467', 'amcarthurn@storify.com', 'New Zealand', '068491162-0');
insert into Client (first_name, last_name, phone, email, country, passport_number) values ('Prescott', 'Stanbrooke', '944-585-0207', 'pstanbrookeo@examiner.com', 'China', '987258979-8');
insert into Client (first_name, last_name, phone, email, country, passport_number) values ('Fey', 'Kemball', '172-686-3798', 'fkemballp@sciencedaily.com', 'Finland', '035878395-X');
insert into Client (first_name, last_name, phone, email, country, passport_number) values ('Kelsey', 'Rennebach', '276-199-3158', 'krennebachq@shareasale.com', 'France', '060993752-9');
insert into Client (first_name, last_name, phone, email, country, passport_number) values ('Bev', 'Adlard', '958-666-9072', 'badlardr@amazon.co.jp', 'Yemen', '511336858-X');
insert into Client (first_name, last_name, phone, email, country, passport_number) values ('Allianora', 'Avramovsky', '861-416-9105', 'aavramovskys@usatoday.com', 'Russia', '252402411-3');
insert into Client (first_name, last_name, phone, email, country, passport_number) values ('Kyle', 'Smallacombe', '967-764-7440', 'ksmallacombet@nytimes.com', 'Indonesia', '950230923-5');

insert into RoomType values(null, 'Standard single', 1, 1000);
insert into RoomType values(null, 'Standard double', 2, 1500);
insert into RoomType values(null, 'Luxe single', 1, 2000);
insert into RoomType values(null, 'Luxe double', 2, 2500);
insert into RoomType values(null, 'Family', 4, 3000);
insert into RoomType values(null, 'President', 6, 6000);

insert into Room values(null, 1, 1, 0);
insert into Room values(null, 1, 1, 0);
insert into Room values(null, 2, 2, 0);
insert into Room values(null, 2, 2, 0);
insert into Room values(null, 3, 3, 0);
insert into Room values(null, 3, 4, 0);
insert into Room values(null, 4, 5, 0);
insert into Room values(null, 5, 6, 0);

insert into Reservation values(null, 1, 1, '14/12/2020 09:00', '21/12/2020 11:45', 'In progress', 1234);
UPDATE Room SET occupied = 1 WHERE room_id = 1;
        ";
    }
}
