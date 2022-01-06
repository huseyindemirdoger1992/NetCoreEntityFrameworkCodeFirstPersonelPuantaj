-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 06 Oca 2022, 22:48:18
-- Sunucu sürümü: 10.4.22-MariaDB
-- PHP Sürümü: 8.1.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `netcoreentityframeworkcodefirstpersonelpuantaj`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `departman`
--

CREATE TABLE `departman` (
  `Id` int(11) NOT NULL,
  `Ad` longtext DEFAULT NULL,
  `Aciklama` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Tablo döküm verisi `departman`
--

INSERT INTO `departman` (`Id`, `Ad`, `Aciklama`) VALUES
(1, 'Boş Departman', 'Silinen Departmana Bağlı Personeller Burada Toplanır.'),
(11, 'Kasa', 'Satış Ve İade'),
(14, 'Kamera', 'Görsel Foto Ve Video Araçları'),
(15, 'Beyaz Eşya', 'Ev Araç Gereçleri');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `personel`
--

CREATE TABLE `personel` (
  `Id` int(11) NOT NULL,
  `Pazartesi` longtext DEFAULT NULL,
  `Sali` longtext DEFAULT NULL,
  `Carsamba` longtext DEFAULT NULL,
  `Persembe` longtext DEFAULT NULL,
  `Cuma` longtext DEFAULT NULL,
  `Cumartesi` longtext DEFAULT NULL,
  `Pazar` longtext DEFAULT NULL,
  `DepatmanId` int(11) NOT NULL,
  `Ad` longtext DEFAULT NULL,
  `Soyad` longtext DEFAULT NULL,
  `Telefon` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Tablo döküm verisi `personel`
--

INSERT INTO `personel` (`Id`, `Pazartesi`, `Sali`, `Carsamba`, `Persembe`, `Cuma`, `Cumartesi`, `Pazar`, `DepatmanId`, `Ad`, `Soyad`, `Telefon`) VALUES
(9, 'Sabah', 'Öğle', 'İzin', 'Sabah', 'Sabah', 'Öğle', 'Öğle', 11, 'Emel ', 'Elif', '7852785'),
(10, 'Öğle', 'Sabah', 'Öğle', 'Öğle', 'Öğle', 'Sabah', 'Full', 14, 'Hüseyin', 'Demirdöğer', '866464646'),
(11, 'Sabah', 'Öğle', 'Sabah', 'Öğle', 'Full', 'Öğle', 'İzin', 11, 'Semra', 'Demirdöğer', '66464646464'),
(12, 'Öğle', 'Sabah', 'Full', 'İzin', 'Sabah', 'Full', 'Sabah', 15, 'Murat ', 'Özdemir', '851');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `vardiya`
--

CREATE TABLE `vardiya` (
  `Id` int(11) NOT NULL,
  `Ad` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Tablo döküm verisi `vardiya`
--

INSERT INTO `vardiya` (`Id`, `Ad`) VALUES
(6, 'Sabah'),
(7, 'Öğle'),
(8, 'İzin'),
(9, 'Full');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `__efmigrationshistory`
--

CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(95) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Tablo döküm verisi `__efmigrationshistory`
--

INSERT INTO `__efmigrationshistory` (`MigrationId`, `ProductVersion`) VALUES
('20220106125221_DB-V1', '3.1.3'),
('20220106125505_DB-V2', '3.1.3'),
('20220106140642_DB-V3', '3.1.3'),
('20220106150344_DB-V4', '3.1.3');

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `departman`
--
ALTER TABLE `departman`
  ADD PRIMARY KEY (`Id`);

--
-- Tablo için indeksler `personel`
--
ALTER TABLE `personel`
  ADD PRIMARY KEY (`Id`);

--
-- Tablo için indeksler `vardiya`
--
ALTER TABLE `vardiya`
  ADD PRIMARY KEY (`Id`);

--
-- Tablo için indeksler `__efmigrationshistory`
--
ALTER TABLE `__efmigrationshistory`
  ADD PRIMARY KEY (`MigrationId`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `departman`
--
ALTER TABLE `departman`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- Tablo için AUTO_INCREMENT değeri `personel`
--
ALTER TABLE `personel`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- Tablo için AUTO_INCREMENT değeri `vardiya`
--
ALTER TABLE `vardiya`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
