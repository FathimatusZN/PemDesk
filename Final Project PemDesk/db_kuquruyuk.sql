-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 02 Jun 2024 pada 08.00
-- Versi server: 10.4.28-MariaDB
-- Versi PHP: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_kuquruyuk`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `detail_transaksi`
--

CREATE TABLE `detail_transaksi` (
  `id_detail` int(11) NOT NULL,
  `ID_MENU` varchar(10) DEFAULT NULL,
  `ID_TRANSAKSI` varchar(30) DEFAULT NULL,
  `MENU_TRANSAKSI` varchar(30) DEFAULT NULL,
  `QTY_DETAIL` int(11) DEFAULT NULL,
  `HARGA_TRANSAKSI` int(11) DEFAULT NULL,
  `SUBTOTAL` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `detail_transaksi`
--

INSERT INTO `detail_transaksi` (`id_detail`, `ID_MENU`, `ID_TRANSAKSI`, `MENU_TRANSAKSI`, `QTY_DETAIL`, `HARGA_TRANSAKSI`, `SUBTOTAL`) VALUES
(27, 'MENU004', 'INV/001/28/12/2023', 'CP Sambal Matah', 4, 13000, 52000),
(28, 'MENU002', 'INV/001/28/12/2023', 'Es Teh', 3, 5000, 15000),
(29, 'MENU011', 'INV/001/28/12/2023', 'Choco Latte', 1, 10000, 10000),
(30, 'MENU008', 'INV/002/28/12/2023', 'CP Teriyaki', 1, 13000, 13000),
(31, 'MENU006', 'INV/002/28/12/2023', 'Mushroom Crispy', 2, 10000, 20000),
(32, 'MENU009', 'INV/002/28/12/2023', 'Matcha Latte', 1, 10000, 10000),
(33, 'MENU001', 'INV/003/29/12/2023', 'CP FIRE', 2, 14000, 28000),
(34, 'MENU009', 'INV/003/29/12/2023', 'Matcha Latte', 3, 10000, 30000),
(35, 'MENU019', 'INV/003/29/12/2023', 'Garlic Mushroom', 1, 12000, 12000),
(36, 'MENU002', 'INV/003/29/12/2023', 'Es Teh', 1, 5000, 5000),
(37, 'MENU003', 'INV/004/29/12/2023', 'CP Mozarella', 2, 15000, 30000),
(38, 'MENU011', 'INV/004/29/12/2023', 'Choco Latte', 2, 10000, 20000),
(39, 'MENU010', 'INV/004/29/12/2023', 'Risol Mayo', 1, 5000, 5000),
(40, 'MENU012', 'INV/005/29/12/2023', 'CP Blackpaper', 3, 13500, 40500),
(41, 'MENU021', 'INV/005/29/12/2023', 'Air Mineral', 5, 4000, 20000),
(42, 'MENU019', 'INV/005/29/12/2023', 'Garlic Mushroom', 3, 12000, 36000),
(43, 'MENU010', 'INV/005/29/12/2023', 'Risol Mayo', 2, 5000, 10000),
(44, 'MENU004', 'INV/006/29/12/2023', 'CP Sambal Matah', 2, 13000, 26000),
(45, 'MENU014', 'INV/006/29/12/2023', 'Choco Ovaltine', 2, 10000, 20000),
(46, 'MENU012', 'INV/007/29/12/2023', 'CP Blackpaper', 2, 13500, 27000),
(47, 'MENU020', 'INV/007/29/12/2023', 'CP Salted Egg', 1, 14000, 14000),
(48, 'MENU009', 'INV/007/29/12/2023', 'Matcha Latte', 1, 10000, 10000),
(49, 'MENU021', 'INV/007/29/12/2023', 'Air Mineral', 3, 4000, 12000),
(50, 'MENU006', 'INV/007/29/12/2023', 'Mushroom Crispy', 1, 10000, 10000),
(51, 'MENU017', 'INV/007/29/12/2023', 'French Fries', 1, 10000, 10000),
(52, 'MENU013', 'INV/008/29/12/2023', 'CP Mentai', 2, 14000, 28000),
(53, 'MENU016', 'INV/008/29/12/2023', 'Tiramisu', 1, 10000, 10000);

-- --------------------------------------------------------

--
-- Struktur dari tabel `jenis_menu`
--

CREATE TABLE `jenis_menu` (
  `ID_JENIS` varchar(10) NOT NULL,
  `JENISMENU` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `jenis_menu`
--

INSERT INTO `jenis_menu` (`ID_JENIS`, `JENISMENU`) VALUES
('j_makanan', 'Makanan'),
('j_minuman', 'Minuman'),
('j_snack', 'Snack');

-- --------------------------------------------------------

--
-- Struktur dari tabel `kasir`
--

CREATE TABLE `kasir` (
  `ID_KASIR` varchar(10) NOT NULL,
  `ID_SHIFT` varchar(10) DEFAULT NULL,
  `NAMA_KASIR` varchar(20) DEFAULT NULL,
  `PASS_KASIR` varchar(20) DEFAULT NULL,
  `TELP_KASIR` varchar(15) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `kasir`
--

INSERT INTO `kasir` (`ID_KASIR`, `ID_SHIFT`, `NAMA_KASIR`, `PASS_KASIR`, `TELP_KASIR`) VALUES
('KSR001', 'shift001', 'LALA', 'Lala123', '08999123123'),
('KSR002', 'shift002', 'DODO MARDODOO', 'Dodo123', '0987564321'),
('KSR003', 'shift001', 'ANDY PARKK', 'andy123', '0898989833'),
('KSR004', 'shift002', 'LILY POTTER', 'Lily321', '0812341234'),
('KSR005', 'shift002', 'NAVY AJRINA', 'Navy321', '099998887766');

-- --------------------------------------------------------

--
-- Struktur dari tabel `menu`
--

CREATE TABLE `menu` (
  `ID_MENU` varchar(10) NOT NULL,
  `ID_JENIS` varchar(10) DEFAULT NULL,
  `NAMA_MENU` varchar(30) DEFAULT NULL,
  `HARGA_MENU` int(11) DEFAULT NULL,
  `STOK` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `menu`
--

INSERT INTO `menu` (`ID_MENU`, `ID_JENIS`, `NAMA_MENU`, `HARGA_MENU`, `STOK`) VALUES
('MENU001', 'j_makanan', 'CP FIRE', 14000, 10),
('MENU002', 'j_minuman', 'Es Teh', 5000, 4),
('MENU003', 'j_makanan', 'CP Mozarella', 15000, 7),
('MENU004', 'j_makanan', 'CP Sambal Matah', 13000, 13),
('MENU005', 'j_minuman', 'Choco Hazelnut', 10000, 5),
('MENU006', 'j_snack', 'Mushroom Crispy', 10000, 14),
('MENU007', 'j_snack', 'Potato Wedges', 10000, 10),
('MENU008', 'j_makanan', 'CP Teriyaki', 13000, 18),
('MENU009', 'j_minuman', 'Matcha Latte', 10000, 15),
('MENU010', 'j_snack', 'Risol Mayo', 5000, 6),
('MENU011', 'j_minuman', 'Choco Latte', 10000, 7),
('MENU012', 'j_makanan', 'CP Blackpaper', 13500, 20),
('MENU013', 'j_makanan', 'CP Mentai', 14000, 21),
('MENU014', 'j_minuman', 'Choco Ovaltine', 10000, 10),
('MENU015', 'j_minuman', 'Choco Oreo', 10000, 9),
('MENU016', 'j_minuman', 'Tiramisu', 10000, 9),
('MENU017', 'j_snack', 'French Fries', 10000, 12),
('MENU018', 'j_makanan', 'CP Indomie', 13000, 20),
('MENU019', 'j_snack', 'Garlic Mushroom', 12000, 12),
('MENU020', 'j_makanan', 'CP Salted Egg', 14000, 13),
('MENU021', 'j_minuman', 'Air Mineral', 4000, 42);

-- --------------------------------------------------------

--
-- Struktur dari tabel `shift_kasir`
--

CREATE TABLE `shift_kasir` (
  `ID_SHIFT` varchar(10) NOT NULL,
  `JADWAL` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `shift_kasir`
--

INSERT INTO `shift_kasir` (`ID_SHIFT`, `JADWAL`) VALUES
('shift001', '07.00 - 12.00'),
('shift002', '12.00 - 17.00');

-- --------------------------------------------------------

--
-- Struktur dari tabel `transaksi`
--

CREATE TABLE `transaksi` (
  `ID_TRANSAKSI` varchar(30) NOT NULL,
  `ID_KASIR` varchar(10) DEFAULT NULL,
  `NAMA_PEMBELI` varchar(30) DEFAULT NULL,
  `QTY_MENU` int(11) DEFAULT NULL,
  `TOTAL_HARGA` int(11) DEFAULT NULL,
  `BAYAR` int(11) DEFAULT NULL,
  `KEMBALI` int(11) DEFAULT NULL,
  `WAKTU` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `transaksi`
--

INSERT INTO `transaksi` (`ID_TRANSAKSI`, `ID_KASIR`, `NAMA_PEMBELI`, `QTY_MENU`, `TOTAL_HARGA`, `BAYAR`, `KEMBALI`, `WAKTU`) VALUES
('INV/001/28/12/2023', 'KSR001', 'Lala', 8, 77000, 80000, 3000, '2023-12-28 17:20:56'),
('INV/002/28/12/2023', 'KSR002', 'Dodo', 4, 43000, 50000, 7000, '2023-12-28 17:21:12'),
('INV/003/29/12/2023', 'KSR001', 'Nana', 7, 75000, 80000, 5000, '2023-12-28 17:30:49'),
('INV/004/29/12/2023', 'KSR005', 'Ara', 5, 55000, 60000, 5000, '2023-12-29 04:54:38'),
('INV/005/29/12/2023', 'KSR005', 'Anis', 13, 106500, 110000, 3500, '2023-12-29 04:59:31'),
('INV/006/29/12/2023', 'KSR001', 'Nanaa', 4, 46000, 50000, 4000, '2023-12-29 14:01:18'),
('INV/007/29/12/2023', 'KSR004', 'Harry', 9, 83000, 90000, 7000, '2023-12-29 14:12:48'),
('INV/008/29/12/2023', 'KSR004', 'Luna', 3, 38000, 40000, 2000, '2023-12-29 14:13:33');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `detail_transaksi`
--
ALTER TABLE `detail_transaksi`
  ADD PRIMARY KEY (`id_detail`),
  ADD KEY `FK_TERMASUK_KE` (`ID_MENU`),
  ADD KEY `FK_TERMUAT_DI` (`ID_TRANSAKSI`);

--
-- Indeks untuk tabel `jenis_menu`
--
ALTER TABLE `jenis_menu`
  ADD PRIMARY KEY (`ID_JENIS`);

--
-- Indeks untuk tabel `kasir`
--
ALTER TABLE `kasir`
  ADD PRIMARY KEY (`ID_KASIR`),
  ADD KEY `FK_MEMPUNYAI` (`ID_SHIFT`);

--
-- Indeks untuk tabel `menu`
--
ALTER TABLE `menu`
  ADD PRIMARY KEY (`ID_MENU`),
  ADD KEY `FK_MEMILIKI` (`ID_JENIS`);

--
-- Indeks untuk tabel `shift_kasir`
--
ALTER TABLE `shift_kasir`
  ADD PRIMARY KEY (`ID_SHIFT`);

--
-- Indeks untuk tabel `transaksi`
--
ALTER TABLE `transaksi`
  ADD PRIMARY KEY (`ID_TRANSAKSI`),
  ADD KEY `FK_MEMPROSES` (`ID_KASIR`);

--
-- AUTO_INCREMENT untuk tabel yang dibuang
--

--
-- AUTO_INCREMENT untuk tabel `detail_transaksi`
--
ALTER TABLE `detail_transaksi`
  MODIFY `id_detail` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=54;

--
-- Ketidakleluasaan untuk tabel pelimpahan (Dumped Tables)
--

--
-- Ketidakleluasaan untuk tabel `detail_transaksi`
--
ALTER TABLE `detail_transaksi`
  ADD CONSTRAINT `FK_TERMASUK_KE` FOREIGN KEY (`ID_MENU`) REFERENCES `menu` (`ID_MENU`),
  ADD CONSTRAINT `FK_TERMUAT_DI` FOREIGN KEY (`ID_TRANSAKSI`) REFERENCES `transaksi` (`ID_TRANSAKSI`);

--
-- Ketidakleluasaan untuk tabel `kasir`
--
ALTER TABLE `kasir`
  ADD CONSTRAINT `FK_MEMPUNYAI` FOREIGN KEY (`ID_SHIFT`) REFERENCES `shift_kasir` (`ID_SHIFT`);

--
-- Ketidakleluasaan untuk tabel `menu`
--
ALTER TABLE `menu`
  ADD CONSTRAINT `FK_MEMILIKI` FOREIGN KEY (`ID_JENIS`) REFERENCES `jenis_menu` (`ID_JENIS`);

--
-- Ketidakleluasaan untuk tabel `transaksi`
--
ALTER TABLE `transaksi`
  ADD CONSTRAINT `FK_MEMPROSES` FOREIGN KEY (`ID_KASIR`) REFERENCES `kasir` (`ID_KASIR`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
