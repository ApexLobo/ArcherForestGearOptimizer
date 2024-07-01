using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static ArcherForestGearOptimizer.Archer;

namespace ArcherForestGearOptimizer {
    public static class FileManager {
        private static string getExeFilePath() {
            // Get the directory of the current executable
            return Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        }
        public static void savePlayerData() {
            string filePath = getExeFilePath();
            string fullPath = Path.Combine(filePath, "player_data.json");
            string jsonData = System.Text.Json.JsonSerializer.Serialize(GlobalData.player);
            File.WriteAllText(fullPath, jsonData);
        }
        public static void savePlayerData(string fullPath) {
            string jsonData = System.Text.Json.JsonSerializer.Serialize(GlobalData.player);
            File.WriteAllText(fullPath, jsonData);
        }
        public static Player loadPlayerData() {
            string filePath = getExeFilePath();
            string fullPath = Path.Combine(filePath, "player_data.json");
            if (File.Exists(fullPath)) {
                string jsonData = File.ReadAllText(fullPath);
                return System.Text.Json.JsonSerializer.Deserialize<Player>(jsonData);
            }
            return null;
        }
        public static Player loadPlayerData(string fullPath) {
            if (File.Exists(fullPath)) {
                string jsonData = File.ReadAllText(fullPath);
                return System.Text.Json.JsonSerializer.Deserialize<Player>(jsonData);
            }
            return null;
        }
        public static void saveGearData() {
            string filePath = getExeFilePath();
            string fullPath = Path.Combine(filePath, "gear_data.json");
            string jsonData = System.Text.Json.JsonSerializer.Serialize(GlobalData.gearList);
            File.WriteAllText(fullPath, jsonData);
        }
        public static void saveGearData(string fullPath) {
            string jsonData = System.Text.Json.JsonSerializer.Serialize(GlobalData.gearList);
            File.WriteAllText(fullPath, jsonData);
        }
        public static GearList loadGearData() {
            string filePath = getExeFilePath();
            string fullPath = Path.Combine(filePath, "gear_data.json");
            if (File.Exists(fullPath)) {
                string jsonData = File.ReadAllText(fullPath);
                return System.Text.Json.JsonSerializer.Deserialize<GearList>(jsonData);
            }
            return null;
        }
        public static GearList loadGearData(string fullPath) {
            if (File.Exists(fullPath)) {
                string jsonData = File.ReadAllText(fullPath);
                return System.Text.Json.JsonSerializer.Deserialize<GearList>(jsonData);
            }
            return null;
        }

        public static void saveStoneTeamData() {
            string filePath = getExeFilePath();
            string fullPath = Path.Combine(filePath, "archer_data.json");
            string jsonData = System.Text.Json.JsonSerializer.Serialize(GlobalData.currentStoneTeam);
            File.WriteAllText(fullPath, jsonData);
        }
        public static void saveStoneTeamData(string fullPath) {
            string jsonData = System.Text.Json.JsonSerializer.Serialize(GlobalData.currentStoneTeam);
            File.WriteAllText(fullPath, jsonData);
        }
        public static StoneTeam loadStoneTeamData() {
            string filePath = getExeFilePath();
            string fullPath = Path.Combine(filePath, "archer_data.json");
            if (File.Exists(fullPath)) {
                string jsonData = File.ReadAllText(fullPath);
                return System.Text.Json.JsonSerializer.Deserialize<StoneTeam>(jsonData);
            }
            return null;
        }
        public static StoneTeam loadStoneTeamData(string fullPath) {
            if (File.Exists(fullPath)) {
                string jsonData = File.ReadAllText(fullPath);
                return System.Text.Json.JsonSerializer.Deserialize<StoneTeam>(jsonData);
            }
            return null;
        }
    }
}
