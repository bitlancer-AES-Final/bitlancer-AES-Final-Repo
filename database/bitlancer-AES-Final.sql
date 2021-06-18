-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1:3306
-- Üretim Zamanı: 16 May 2021, 18:34:18
-- Sunucu sürümü: 10.4.10-MariaDB
-- PHP Sürümü: 7.3.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `bitlancer`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `items`
--

DROP TABLE IF EXISTS `items`;
CREATE TABLE IF NOT EXISTS `items` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `item_name` varchar(250) COLLATE utf8_turkish_ci DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `items`
--

INSERT INTO `items` (`id`, `item_name`) VALUES
(2, 'Altın'),
(3, 'Gümüş'),
(4, 'TL'),
(5, 'Elmas');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `item_adds`
--

DROP TABLE IF EXISTS `item_adds`;
CREATE TABLE IF NOT EXISTS `item_adds` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `user_id` int(11) NOT NULL,
  `item_id` int(11) NOT NULL,
  `quantity` int(11) NOT NULL,
  `unit_price` double NOT NULL,
  `date` varchar(255) COLLATE utf8_turkish_ci NOT NULL,
  `state` tinyint(1) NOT NULL,
  `description` text COLLATE utf8_turkish_ci NOT NULL,
  PRIMARY KEY (`id`),
  KEY `user_id` (`user_id`),
  KEY `item_id` (`item_id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `item_adds`
--

INSERT INTO `item_adds` (`id`, `user_id`, `item_id`, `quantity`, `unit_price`, `date`, `state`, `description`) VALUES
(1, 4, 2, 150, 1, '2021-05-06', 1, 'TAMAMLANDI'),
(2, 3, 4, 1200, 1, '2021-05-07', 1, 'TAMAMLANDI.'),
(3, 5, 4, 3000, 1, '2021-15-2', 1, 'TAmamlandı'),
(4, 4, 3, 1500, 1, '16.05.2021 15:33:50', 0, 'BEKLENİYOR');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `item_orders`
--

DROP TABLE IF EXISTS `item_orders`;
CREATE TABLE IF NOT EXISTS `item_orders` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `destination_user_id` int(11) NOT NULL,
  `source_user_id` int(11) NOT NULL,
  `item_id` int(11) NOT NULL,
  `order_unit_price` double NOT NULL,
  `order_quantity` int(11) NOT NULL,
  `order_date` varchar(255) COLLATE utf8_turkish_ci NOT NULL,
  PRIMARY KEY (`id`),
  KEY `destination_user_id` (`destination_user_id`,`source_user_id`,`item_id`),
  KEY `source_user_id` (`source_user_id`),
  KEY `item_id` (`item_id`)
) ENGINE=InnoDB AUTO_INCREMENT=802 DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `item_orders`
--

INSERT INTO `item_orders` (`id`, `destination_user_id`, `source_user_id`, `item_id`, `order_unit_price`, `order_quantity`, `order_date`) VALUES
(1, 4, 3, 2, 5, 510, '2021-05-06'),
(2, 3, 4, 3, 7.7, 1452, '2021-05-06'),
(22, 4, 3, 2, 5, 90, '9.05.2021 17:50:08'),
(23, 4, 5, 2, 7.5, 10, '9.05.2021 17:50:09'),
(33, 4, 3, 3, 1, 3000, '9.05.2021 19:16:11'),
(34, 4, 5, 3, 12, 41, '9.05.2021 19:16:58'),
(214, 4, 5, 3, 12, 2, '9.05.2021 19:28:06'),
(215, 3, 5, 2, 7.5, 1, '9.05.2021 23:35:39'),
(216, 3, 5, 2, 7.5, 1, '9.05.2021 23:36:34'),
(217, 3, 4, 5, 7, 224, '10.05.2021 14:00:35'),
(222, 4, 3, 5, 0, 132, '10.05.2021 14:36:47'),
(665, 3, 4, 5, 0, 1000, '10.05.2021 14:42:54'),
(666, 4, 3, 5, 1, 10, '10.05.2021 14:44:19'),
(779, 3, 4, 5, 0, 10, '10.05.2021 14:48:36'),
(780, 4, 3, 5, 1, 10, '10.05.2021 14:49:42'),
(781, 4, 3, 5, 1, 10, '10.05.2021 14:51:52'),
(782, 4, 3, 5, 1, 10, '10.05.2021 14:56:07'),
(783, 4, 3, 5, 1, 10, '10.05.2021 14:59:30'),
(784, 4, 3, 5, 1, 10, '10.05.2021 15:01:39'),
(785, 4, 3, 5, 10, 10, '10.05.2021 22:01:56'),
(786, 3, 4, 5, 1, 1040, '10.05.2021 23:49:00'),
(787, 4, 5, 2, 7.5, 2, '10.05.2021 23:50:31'),
(788, 4, 5, 2, 7.5, 136, '11.05.2021 19:13:42'),
(789, 4, 5, 2, 1, 10, '11.05.2021 19:21:56'),
(790, 4, 5, 2, 1, 12, '11.05.2021 19:27:56'),
(791, 4, 3, 5, 0, 2, '11.05.2021 19:28:18'),
(792, 4, 3, 5, 0, 2, '11.05.2021 19:29:31'),
(793, 4, 3, 5, 0, 2, '11.05.2021 19:31:52'),
(794, 4, 3, 5, 0, 2, '11.05.2021 19:32:32'),
(795, 4, 3, 5, 0, 2, '11.05.2021 19:34:04'),
(796, 4, 3, 5, 10, 2, '11.05.2021 19:36:25'),
(797, 4, 3, 5, 10, 2, '11.05.2021 19:37:53'),
(798, 4, 3, 5, 10, 2, '11.05.2021 19:38:56'),
(799, 4, 3, 5, 10, 2, '11.05.2021 19:47:50'),
(800, 4, 3, 5, 10, 2, '11.05.2021 19:47:56'),
(801, 3, 4, 5, 9.5, 6, '11.05.2021 19:50:35');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `item_user_infos`
--

DROP TABLE IF EXISTS `item_user_infos`;
CREATE TABLE IF NOT EXISTS `item_user_infos` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `user_id` int(11) NOT NULL,
  `item_id` int(11) NOT NULL,
  `quantity` int(11) NOT NULL,
  `unit_price` double NOT NULL,
  `selling` tinyint(1) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `user_id` (`user_id`,`item_id`),
  KEY `item_id` (`item_id`)
) ENGINE=InnoDB AUTO_INCREMENT=634 DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `item_user_infos`
--

INSERT INTO `item_user_infos` (`id`, `user_id`, `item_id`, `quantity`, `unit_price`, `selling`) VALUES
(3, 4, 2, 110, 12.8, 1),
(4, 3, 4, 9356, 1, 0),
(44, 4, 3, 3043, 12, 0),
(46, 5, 3, 1198, 12, 1),
(47, 3, 2, 2, 1, 0),
(59, 4, 4, 11808, 1, 0),
(503, 3, 5, 956, 10, 1),
(626, 3, 5, 1046, 10, 0),
(627, 4, 2, 160, 1, 0),
(629, 5, 2, 930, 1, 1);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `users`
--

DROP TABLE IF EXISTS `users`;
CREATE TABLE IF NOT EXISTS `users` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `user_full_name` varchar(250) COLLATE utf8_turkish_ci DEFAULT NULL,
  `user_name` varchar(100) COLLATE utf8_turkish_ci DEFAULT NULL,
  `user_password` varchar(100) COLLATE utf8_turkish_ci DEFAULT NULL,
  `user_address` varchar(1000) COLLATE utf8_turkish_ci DEFAULT NULL,
  `user_mail` varchar(250) COLLATE utf8_turkish_ci DEFAULT NULL,
  `user_tc` varchar(255) COLLATE utf8_turkish_ci NOT NULL,
  `user_tel` varchar(255) COLLATE utf8_turkish_ci NOT NULL,
  `user_type_id` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `user_type_id` (`user_type_id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `users`
--

INSERT INTO `users` (`id`, `user_full_name`, `user_name`, `user_password`, `user_address`, `user_mail`, `user_tc`, `user_tel`, `user_type_id`) VALUES
(3, 'Muhammet Sezer Yıldırım', 'sezer_admin', '123', 'Çanakkale', 'asd@gmail.com', '65432156321', '5462133521', 5),
(4, 'Enes Koyuncu', 'enesc', '', 'İzmir', 'asdas@gmail.com', '532156321', '(545) 224-6932', 6),
(5, 'Simge', 'asd', 'asd', 'asd', 'asd', '213', '123', 6),
(6, 'Ali Eren Eriş', 'eren', '123', 'asdasdasd', 'asdasdasd', '123123', '(456) 421-2112', 6);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `user_type_infos`
--

DROP TABLE IF EXISTS `user_type_infos`;
CREATE TABLE IF NOT EXISTS `user_type_infos` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `user_type` varchar(64) COLLATE utf8_turkish_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `user_type_infos`
--

INSERT INTO `user_type_infos` (`id`, `user_type`) VALUES
(5, 'admin'),
(6, 'basic');

--
-- Dökümü yapılmış tablolar için kısıtlamalar
--

--
-- Tablo kısıtlamaları `item_adds`
--
ALTER TABLE `item_adds`
  ADD CONSTRAINT `item_adds_ibfk_1` FOREIGN KEY (`item_id`) REFERENCES `items` (`id`),
  ADD CONSTRAINT `item_adds_ibfk_2` FOREIGN KEY (`user_id`) REFERENCES `users` (`id`);

--
-- Tablo kısıtlamaları `item_orders`
--
ALTER TABLE `item_orders`
  ADD CONSTRAINT `item_orders_ibfk_1` FOREIGN KEY (`destination_user_id`) REFERENCES `users` (`id`),
  ADD CONSTRAINT `item_orders_ibfk_2` FOREIGN KEY (`source_user_id`) REFERENCES `users` (`id`),
  ADD CONSTRAINT `item_orders_ibfk_3` FOREIGN KEY (`item_id`) REFERENCES `items` (`id`);

--
-- Tablo kısıtlamaları `item_user_infos`
--
ALTER TABLE `item_user_infos`
  ADD CONSTRAINT `item_user_infos_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `users` (`id`),
  ADD CONSTRAINT `item_user_infos_ibfk_2` FOREIGN KEY (`item_id`) REFERENCES `items` (`id`);

--
-- Tablo kısıtlamaları `users`
--
ALTER TABLE `users`
  ADD CONSTRAINT `users_ibfk_1` FOREIGN KEY (`user_type_id`) REFERENCES `user_type_infos` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
