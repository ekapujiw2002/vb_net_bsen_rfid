/*
Navicat MySQL Data Transfer

Source Server         : localhost
Source Server Version : 50515
Source Host           : localhost:3306
Source Database       : absen_rfid

Target Server Type    : MYSQL
Target Server Version : 50515
File Encoding         : 65001

Date: 2017-06-05 04:43:47
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `log_absensi`
-- ----------------------------
DROP TABLE IF EXISTS `log_absensi`;
CREATE TABLE `log_absensi` (
  `no` int(11) NOT NULL AUTO_INCREMENT,
  `waktu` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `id_user` varchar(20) NOT NULL,
  `nama` varchar(32) NOT NULL,
  `waktu_masuk` time NOT NULL DEFAULT '08:00:00',
  `waktu_keluar` time NOT NULL DEFAULT '23:00:00',
  PRIMARY KEY (`no`)
) ENGINE=MyISAM AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of log_absensi
-- ----------------------------
INSERT INTO `log_absensi` VALUES ('1', '2017-06-02 17:52:24', '1234', 'Yudi', '05:52:24', '23:00:00');
INSERT INTO `log_absensi` VALUES ('2', '2017-06-02 17:53:03', 'abcdxxx', 'Deri', '05:52:28', '05:53:03');
INSERT INTO `log_absensi` VALUES ('3', '2017-06-02 17:53:51', 'aabbccdd', 'Heriko', '05:52:33', '05:53:51');
INSERT INTO `log_absensi` VALUES ('4', '2017-06-02 17:53:14', '12345', 'Dodol', '05:52:57', '05:53:14');
INSERT INTO `log_absensi` VALUES ('5', '2017-06-03 08:23:06', '1234', 'Yudi', '08:00:00', '23:00:00');
INSERT INTO `log_absensi` VALUES ('6', '2017-06-03 08:35:03', '12345', 'Dodol', '08:32:50', '08:35:03');
INSERT INTO `log_absensi` VALUES ('7', '2017-06-03 08:35:11', 'abcdxxx', 'Deri', '08:32:59', '08:35:11');
INSERT INTO `log_absensi` VALUES ('8', '2017-06-03 08:33:03', 'aabbccdd', 'Heriko', '08:33:03', '23:00:00');

-- ----------------------------
-- Table structure for `registrasi`
-- ----------------------------
DROP TABLE IF EXISTS `registrasi`;
CREATE TABLE `registrasi` (
  `no` int(11) NOT NULL AUTO_INCREMENT,
  `waktu` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `id_user` varchar(20) NOT NULL,
  `nama` varchar(32) NOT NULL,
  PRIMARY KEY (`no`,`id_user`)
) ENGINE=MyISAM AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of registrasi
-- ----------------------------
INSERT INTO `registrasi` VALUES ('2', '2017-06-02 16:35:42', '1234', 'Yudi');
INSERT INTO `registrasi` VALUES ('3', '2017-06-02 17:05:57', 'abcd', 'Yeyen');
INSERT INTO `registrasi` VALUES ('4', '2017-06-02 17:53:42', 'aabbccdd', 'Heriko');
INSERT INTO `registrasi` VALUES ('5', '2017-06-02 17:46:35', 'abcdxxx', 'Deri');
INSERT INTO `registrasi` VALUES ('6', '2017-06-02 17:52:49', '12345', 'Dodol');
