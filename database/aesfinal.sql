-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1:3307
-- Üretim Zamanı: 22 Haz 2021, 16:32:13
-- Sunucu sürümü: 10.4.13-MariaDB
-- PHP Sürümü: 7.3.21

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `aesfinal`
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
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `items`
--

INSERT INTO `items` (`id`, `item_name`) VALUES
(2, 'Altın'),
(3, 'Gümüş'),
(4, 'TL'),
(5, 'Elmas'),
(6, 'Dolar'),
(7, 'Euro'),
(8, 'Sterlin');

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
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `item_adds`
--

INSERT INTO `item_adds` (`id`, `user_id`, `item_id`, `quantity`, `unit_price`, `date`, `state`, `description`) VALUES
(1, 4, 2, 150, 1, '2021-05-06', 1, 'TAMAMLANDI'),
(2, 3, 4, 1200, 1, '2021-05-07', 1, 'TAMAMLANDI.'),
(3, 5, 4, 3000, 1, '2021-15-2', 1, 'TAmamlandı'),
(4, 4, 3, 1500, 1, '16.05.2021 15:33:50', 0, 'BEKLENİYOR'),
(5, 5, 2, 150, 12, '16.05.2021 15:33:50', 1, 'TAMAMLANDI'),
(6, 6, 2, 500, 4, '16.05.2021 15:33:50', 1, 'TAMAMLANDI'),
(7, 3, 4, 260, 1, '22.06.2021 02:19:45', 1, 'Kendime para xd');

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
) ENGINE=InnoDB AUTO_INCREMENT=815 DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `item_orders`
--

INSERT INTO `item_orders` (`id`, `destination_user_id`, `source_user_id`, `item_id`, `order_unit_price`, `order_quantity`, `order_date`) VALUES
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
(801, 3, 4, 5, 9.5, 6, '11.05.2021 19:50:35'),
(802, 3, 5, 2, 1, 5, '19.06.2021 20:58:22'),
(803, 3, 5, 2, 1, 9, '19.06.2021 21:01:35'),
(804, 3, 4, 2, 50.5, 1, '19.06.2021 21:01:35'),
(805, 3, 4, 2, 50.5, 1, '19.06.2021 21:32:48'),
(806, 3, 4, 2, 50.5, 1, '19.06.2021 21:34:25'),
(807, 3, 4, 2, 50.5, 1, '19.06.2021 21:34:54'),
(808, 3, 4, 2, 50.5, 1, '19.06.2021 21:40:27'),
(809, 3, 4, 2, 50.5, 1, '20.06.2021 06:10:16'),
(810, 3, 4, 2, 50.5, 1, '20.06.2021 06:10:20'),
(811, 3, 4, 2, 50.5, 1, '20.06.2021 06:10:24'),
(812, 3, 4, 2, 50.5, 1, '20.06.2021 06:10:27'),
(813, 3, 4, 2, 50.5, 1, '20.06.2021 06:10:27'),
(814, 3, 4, 2, 50.5, 0, '20.06.2021 06:11:31');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `item_order_request`
--

DROP TABLE IF EXISTS `item_order_request`;
CREATE TABLE IF NOT EXISTS `item_order_request` (
  `request_id` int(11) NOT NULL AUTO_INCREMENT,
  `item_id` int(11) NOT NULL,
  `source_user_id` int(11) NOT NULL,
  `destination_user_id` int(11) DEFAULT NULL,
  `order_request_unit_price` double NOT NULL,
  `order_request_quantity` int(11) NOT NULL,
  `state` int(11) NOT NULL,
  `order_request_date` varchar(255) COLLATE utf8_turkish_ci NOT NULL,
  `order_request_finish_date` varchar(255) COLLATE utf8_turkish_ci DEFAULT NULL,
  PRIMARY KEY (`request_id`),
  KEY `source_user_id` (`source_user_id`)
) ENGINE=MyISAM AUTO_INCREMENT=12 DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `item_order_request`
--

INSERT INTO `item_order_request` (`request_id`, `item_id`, `source_user_id`, `destination_user_id`, `order_request_unit_price`, `order_request_quantity`, `state`, `order_request_date`, `order_request_finish_date`) VALUES
(1, 2, 5, NULL, 5, 100, 0, '20.06.2021 07:54:23', NULL),
(3, 3, 4, NULL, 10, 5, 0, '20.06.2021 08:22:43', NULL),
(8, 3, 3, NULL, 220, 1, 0, '22.06.2021 00:11:48', NULL),
(5, 5, 4, NULL, 50, 100, 0, '20.06.2021 08:30:52', NULL),
(6, 3, 4, NULL, 2000, 1000, 0, '20.06.2021 17:14:55', NULL),
(7, 3, 3, NULL, 999, 666, 0, '20.06.2021 18:38:39', NULL),
(9, 3, 3, NULL, 262, 1, 0, '22.06.2021 02:19:09', NULL),
(10, 3, 3, NULL, 41, 1, 0, '22.06.2021 02:24:50', NULL),
(11, 5, 5, 4, 111, 111, 1, '20.06.2021 07:54:23', '20.06.2021 07:55:23');

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
) ENGINE=InnoDB AUTO_INCREMENT=640 DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `item_user_infos`
--

INSERT INTO `item_user_infos` (`id`, `user_id`, `item_id`, `quantity`, `unit_price`, `selling`) VALUES
(44, 4, 3, 3043, 12, 0),
(46, 5, 3, 0, 12, 1),
(503, 3, 5, 26, 10, 1),
(626, 3, 5, 116, 10, 0),
(634, 5, 4, 209260, 1, 0),
(635, 4, 4, 0, 1, 0),
(636, 5, 5, 0, 9, 1),
(638, 3, 4, 41, 1, 0),
(639, 3, 3, 23, 220, 0);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `source_destination_change_log`
--

DROP TABLE IF EXISTS `source_destination_change_log`;
CREATE TABLE IF NOT EXISTS `source_destination_change_log` (
  `request_id` int(11) NOT NULL,
  `item_id` int(11) DEFAULT NULL,
  `source_user_id` int(11) DEFAULT NULL,
  `destination_user_id` int(11) DEFAULT NULL,
  `order_request_unit_price` double DEFAULT NULL,
  `order_request_quantity` int(11) DEFAULT NULL,
  `state_source` int(11) DEFAULT NULL,
  `state_destination` int(11) DEFAULT NULL,
  `source_change_date` varchar(255) COLLATE utf8_turkish_ci DEFAULT NULL,
  `destination_change_date` varchar(255) COLLATE utf8_turkish_ci DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `source_destination_change_log`
--

INSERT INTO `source_destination_change_log` (`request_id`, `item_id`, `source_user_id`, `destination_user_id`, `order_request_unit_price`, `order_request_quantity`, `state_source`, `state_destination`, `source_change_date`, `destination_change_date`) VALUES
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:41:56'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:41:57'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:41:58'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:44:58'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:44:57'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:44:56'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:44:55'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:44:54'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:44:53'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:44:52'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:44:51'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:44:50'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:44:49'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:44:48'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:44:47'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:44:46'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:44:45'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:44:44'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:44:43'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:44:42'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:44:41'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:44:40'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:44:39'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:44:38'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:44:37'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:44:36'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:44:35'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:44:34'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:44:33'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:44:32'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:44:31'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:44:30'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:44:29'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:44:28'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:44:27'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:44:26'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:44:25'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:44:24'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:44:23'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:44:22'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:44:21'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:44:20'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:44:19'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:44:18'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:44:17'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:44:16'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:44:15'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:44:14'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:44:13'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:44:12'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:44:11'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:44:10'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:44:09'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:44:08'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:44:07'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:44:06'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:44:05'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:44:04'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:44:03'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:44:02'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:44:01'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:44:00'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:43:59'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:43:58'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:43:57'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:43:56'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:43:55'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:43:54'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:43:53'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:43:52'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:43:51'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:43:50'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:43:49'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:43:48'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:43:47'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:43:46'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:43:45'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:43:44'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:43:43'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:43:42'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:43:41'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:43:40'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:43:39'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:43:38'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:43:37'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:43:36'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:43:35'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:43:34'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:43:33'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:43:32'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:43:31'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:43:30'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:43:29'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:43:28'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:43:27'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:43:26'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:43:25'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:43:24'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:43:23'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:43:22'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:43:21'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:43:20'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:43:19'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:43:18'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:43:17'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:43:16'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:43:15'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:43:14'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:43:13'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:43:12'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:43:11'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:43:10'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:43:09'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:43:08'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:43:07'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:43:06'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:43:05'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:43:04'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:43:03'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:43:02'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:43:01'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:43:00'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:42:59'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:42:58'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:42:57'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:42:56'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:42:55'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:42:54'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:42:53'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:42:52'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:42:51'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:42:50'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:42:49'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:42:48'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:42:47'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:42:46'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:42:45'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:42:44'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:42:43'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:42:42'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:42:41'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:42:40'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:42:39'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:42:38'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:42:37'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:42:36'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:42:35'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:42:34'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:42:33'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:42:32'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:42:31'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:42:30'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:42:29'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:42:28'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:42:27'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:42:26'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:42:25'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:42:24'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:42:23'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:42:22'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:42:21'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:42:20'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:42:19'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:42:18'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:42:17'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:42:16'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:42:15'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:42:14'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:42:13'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:42:12'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:42:11'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:42:10'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:42:09'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:42:08'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:42:07'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:42:06'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:42:05'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:42:04'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:42:03'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:42:02'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:42:01'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:42:00'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:41:59'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:41:54'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:41:55'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:41:52'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:41:53'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:41:50'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:41:51'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:41:49'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:41:47'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:41:48'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:41:46'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:41:44'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:41:45'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:41:43'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:41:41'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:41:42'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:41:40'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:41:38'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:41:39'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:41:37'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:41:35'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:41:36'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:41:34'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:41:32'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:41:33'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:41:31'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:41:29'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:41:30'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:41:28'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:41:26'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:41:27'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:41:25'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:41:23'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:41:24'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:41:22'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:41:21'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:44:59'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:45:00'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:45:01'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:45:02'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:45:03'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:45:04'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:45:05'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:45:06'),
(8, 3, 3, 5, 220, 1, NULL, 1, NULL, '22.06.2021 02:45:07');

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
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `users`
--

INSERT INTO `users` (`id`, `user_full_name`, `user_name`, `user_password`, `user_address`, `user_mail`, `user_tc`, `user_tel`, `user_type_id`) VALUES
(3, 'Muhammet Sezer Yıldırım', 'sezer_admin', '123', 'Çanakkale', 'asd@gmail.com', '65432156321', '5462133521', 5),
(4, 'Enes Koyuncu', 'enes', 'enes', 'İzmir', 'asdas@gmail.com', '532156321', '(545) 224-6932', 6),
(5, 'Simge', 'asd', 'asd', 'asd', 'asd', '213', '123', 6),
(6, 'Ali Eren Eriş', 'eren', '123', 'asdasdasd', 'asdasdasd', '123123', '(456) 421-2112', 6),
(7, 'Aleyna', 'aleyna', 'aleyna', 'Lüleburgaz', 'aleyna@gmail.com', '12345678910', '0541541424', 6);

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
