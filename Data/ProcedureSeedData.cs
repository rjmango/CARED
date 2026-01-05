using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CARED.Models;

namespace CARED.Data
{
    public static class ProcedureSeedData
    {
        public static List<Procedure> GetInitialProcedures()
        {
            return new List<Procedure>
            {
                // NOTE: The Primary Key (ProcedureID) must be explicitly provided for HasData
                new Procedure
                {
                    ProcedureID = 1,
                    ProcedureName = "URINALYSIS",
                    Amount = 182.00M,
                    Group = "LABORATORY TESTS",
                    SubGroup = "I. CLINICAL MICROSCOPY"
                },
                new Procedure
                {
                    ProcedureID = 2,
                    ProcedureName = "STOOL",
                    Amount = 182.00M,
                    Group = "LABORATORY TESTS",
                    SubGroup = "I. CLINICAL MICROSCOPY"
                },
                new Procedure
                {
                    ProcedureID = 3,
                    ProcedureName = "FECAL OCCULT BLOOD",
                    Amount = 275.00M,
                    Group = "LABORATORY TESTS",
                    SubGroup = "I. CLINICAL MICROSCOPY"
                },
                new Procedure
                {
                    ProcedureID = 4,
                    ProcedureName = "PT (SERUM)",
                    Amount = 385.00M,
                    Group = "LABORATORY TESTS",
                    SubGroup = "II. SEROLOGY"
                },
                new Procedure
                {
                    ProcedureID = 5,
                    ProcedureName = "BLOOD TYPING",
                    Amount = 242.00M,
                    Group = "LABORATORY TESTS",
                    SubGroup = "II. SEROLOGY"
                },
                new Procedure
                {
                    ProcedureID = 6,
                    ProcedureName = "VDRL",
                    Amount = 440.00M,
                    Group = "LABORATORY TESTS",
                    SubGroup = "II. SEROLOGY"
                },
                new Procedure
                {
                    ProcedureID = 7,
                    ProcedureName = "HBsAg",
                    Amount = 440.00M,
                    Group = "LABORATORY TESTS",
                    SubGroup = "II. SEROLOGY"
                },
                new Procedure
                {
                    ProcedureID = 8,
                    ProcedureName = "Anti- HBs",
                    Amount = 440.00M,
                    Group = "LABORATORY TESTS",
                    SubGroup = "II. SEROLOGY"
                },
                new Procedure
                {
                    ProcedureID = 9,
                    ProcedureName = "NS1, IgM/IgG",
                    Amount = 2024.00M,
                    Group = "LABORATORY TESTS",
                    SubGroup = "II. SEROLOGY"
                },
                new Procedure
                {
                    ProcedureID = 10,
                    ProcedureName = "HIV SCREENING",
                    Amount = 770.00M,
                    Group = "LABORATORY TESTS",
                    SubGroup = "II. SEROLOGY"
                },
                new Procedure
                {
                    ProcedureID = 11,
                    ProcedureName = "CBC",
                    Amount = 300.00M,
                    Group = "LABORATORY TESTS",
                    SubGroup = "III. HEMATOLOGY"
                },
                new Procedure
                {
                    ProcedureID = 12,
                    ProcedureName = "CLOTTING TIME",
                    Amount = 193.00M,
                    Group = "LABORATORY TESTS",
                    SubGroup = "III. HEMATOLOGY"
                },
                new Procedure
                {
                    ProcedureID = 13,
                    ProcedureName = "BLEEDING TIME",
                    Amount = 193.00M,
                    Group = "LABORATORY TESTS",
                    SubGroup = "III. HEMATOLOGY"
                },
                new Procedure
                {
                    ProcedureID = 14,
                    ProcedureName = "ESR",
                    Amount = 220.00M,
                    Group = "LABORATORY TESTS",
                    SubGroup = "III. HEMATOLOGY"
                },
                new Procedure
                {
                    ProcedureID = 15,
                    ProcedureName = "LIPID PANEL with FBS",
                    Amount = 825.00M,
                    Group = "LABORATORY TESTS",
                    SubGroup = "IV. BLOOD CHEMISTRY"
                },
                new Procedure
                {
                    ProcedureID = 16,
                    ProcedureName = "GLUCOSE/FBS/RBS",
                    Amount = 330.00M,
                    Group = "LABORATORY TESTS",
                    SubGroup = "IV. BLOOD CHEMISTRY"
                },
                new Procedure
                {
                    ProcedureID = 17,
                    ProcedureName = "CHOLESTEROL",
                    Amount = 363.00M,
                    Group = "LABORATORY TESTS",
                    SubGroup = "IV. BLOOD CHEMISTRY"
                },
                new Procedure
                {
                    ProcedureID = 18,
                    ProcedureName = "TRIGLYCERIDES",
                    Amount = 385.00M,
                    Group = "LABORATORY TESTS",
                    SubGroup = "IV. BLOOD CHEMISTRY"
                },
                new Procedure
                {
                    ProcedureID = 19,
                    ProcedureName = "HDL",
                    Amount = 385.00M,
                    Group = "LABORATORY TESTS",
                    SubGroup = "IV. BLOOD CHEMISTRY"
                },
                new Procedure
                {
                    ProcedureID = 20,
                    ProcedureName = "CREATININE",
                    Amount = 330.00M,
                    Group = "LABORATORY TESTS",
                    SubGroup = "IV. BLOOD CHEMISTRY"
                },
                new Procedure
                {
                    ProcedureID = 21,
                    ProcedureName = "BUA",
                    Amount = 303.00M,
                    Group = "LABORATORY TESTS",
                    SubGroup = "IV. BLOOD CHEMISTRY"
                },
                new Procedure
                {
                    ProcedureID = 22,
                    ProcedureName = "BUN",
                    Amount = 303.00M,
                    Group = "LABORATORY TESTS",
                    SubGroup = "IV. BLOOD CHEMISTRY"
                },
                new Procedure
                {
                    ProcedureID = 23,
                    ProcedureName = "SGPT",
                    Amount = 303.00M,
                    Group = "LABORATORY TESTS",
                    SubGroup = "IV. BLOOD CHEMISTRY"
                },
                new Procedure
                {
                    ProcedureID = 24,
                    ProcedureName = "SGOT",
                    Amount = 303.00M,
                    Group = "LABORATORY TESTS",
                    SubGroup = "IV. BLOOD CHEMISTRY"
                },
                new Procedure
                {
                    ProcedureID = 25,
                    ProcedureName = "ALKALINE PHOSPHATASE",
                    Amount = 352.00M,
                    Group = "LABORATORY TESTS",
                    SubGroup = "IV. BLOOD CHEMISTRY"
                },
                new Procedure
                {
                    ProcedureID = 26,
                    ProcedureName = "HbA1C",
                    Amount = 770.00M,
                    Group = "LABORATORY TESTS",
                    SubGroup = "IV. BLOOD CHEMISTRY"
                },
                new Procedure
                {
                    ProcedureID = 27,
                    ProcedureName = "OGTT 75g 2HRS",
                    Amount = 770.00M,
                    Group = "LABORATORY TESTS",
                    SubGroup = "IV. BLOOD CHEMISTRY"
                },
                new Procedure
                {
                    ProcedureID = 28,
                    ProcedureName = "SKULL AP AND LATERAL",
                    Amount = 640.00M,
                    Group = "IMAGING SERVICES",
                    SubGroup = "I. HEAD"
                },
                new Procedure
                {
                    ProcedureID = 29,
                    ProcedureName = "PARANASAL SINUS (CALDWELL @ WATERS)",
                    Amount = 790.00M,
                    Group = "IMAGING SERVICES",
                    SubGroup = "I. HEAD"
                },
                new Procedure
                {
                    ProcedureID = 30,
                    ProcedureName = "SHOULDER AP",
                    Amount = 440.00M,
                    Group = "IMAGING SERVICES",
                    SubGroup = "II. UPPER EXTREMITIES"
                },
                new Procedure
                {
                    ProcedureID = 31,
                    ProcedureName = "FOREARMS AP LATERAL",
                    Amount = 640.00M,
                    Group = "IMAGING SERVICES",
                    SubGroup = "II. UPPER EXTREMITIES"
                },
                new Procedure
                {
                    ProcedureID = 32,
                    ProcedureName = "ELBOW AP LATERAL",
                    Amount = 640.00M,
                    Group = "IMAGING SERVICES",
                    SubGroup = "II. UPPER EXTREMITIES"
                },
                new Procedure
                {
                    ProcedureID = 33,
                    ProcedureName = "WRIST AP LATERAL",
                    Amount = 640.00M,
                    Group = "IMAGING SERVICES",
                    SubGroup = "II. UPPER EXTREMITIES"
                },
                new Procedure
                {
                    ProcedureID = 34,
                    ProcedureName = "HAND PA OBLIQUE and LATERAL",
                    Amount = 790.00M,
                    Group = "IMAGING SERVICES",
                    SubGroup = "II. UPPER EXTREMITIES"
                },
                new Procedure
                {
                    ProcedureID = 35,
                    ProcedureName = "HUMERUS APL",
                    Amount = 640.00M,
                    Group = "IMAGING SERVICES",
                    SubGroup = "II. UPPER EXTREMITIES"
                },
                new Procedure
                {
                    ProcedureID = 36,
                    ProcedureName = "LEG (TIBIA FIBULA) AP LATERAL",
                    Amount = 640.00M,
                    Group = "IMAGING SERVICES",
                    SubGroup = "III. LOWER EXTREMITIES"
                },
                new Procedure
                {
                    ProcedureID = 37,
                    ProcedureName = "KNEE AP AND LATERAL",
                    Amount = 640.00M,
                    Group = "IMAGING SERVICES",
                    SubGroup = "III. LOWER EXTREMITIES"
                },
                new Procedure
                {
                    ProcedureID = 38,
                    ProcedureName = "ANKLE AP OBLIQUE and LATERAL",
                    Amount = 640.00M,
                    Group = "IMAGING SERVICES",
                    SubGroup = "III. LOWER EXTREMITIES"
                },
                new Procedure
                {
                    ProcedureID = 39,
                    ProcedureName = "FOOT AP, OBLIQUE and LATERAL",
                    Amount = 640.00M,
                    Group = "IMAGING SERVICES",
                    SubGroup = "III. LOWER EXTREMITIES"
                },
                new Procedure
                {
                    ProcedureID = 40,
                    ProcedureName = "FOOT LATERAL",
                    Amount = 640.00M,
                    Group = "IMAGING SERVICES",
                    SubGroup = "III. LOWER EXTREMITIES"
                },
                new Procedure
                {
                    ProcedureID = 41,
                    ProcedureName = "CERVICAL SPINE APL",
                    Amount = 790.00M,
                    Group = "IMAGING SERVICES",
                    SubGroup = "IV. VERTEBRAL COLUMN"
                },
                new Procedure
                {
                    ProcedureID = 42,
                    ProcedureName = "CERVICAL SPINE (open mouth) APL",
                    Amount = 790.00M,
                    Group = "IMAGING SERVICES",
                    SubGroup = "IV. VERTEBRAL COLUMN"
                },
                new Procedure
                {
                    ProcedureID = 43,
                    ProcedureName = "LUMBOSACRAL",
                    Amount = 790.00M,
                    Group = "IMAGING SERVICES",
                    SubGroup = "IV. VERTEBRAL COLUMN"
                },
                new Procedure
                {
                    ProcedureID = 44,
                    ProcedureName = "THORACIC SPINE",
                    Amount = 790.00M,
                    Group = "IMAGING SERVICES",
                    SubGroup = "IV. VERTEBRAL COLUMN"
                },
                new Procedure
                {
                    ProcedureID = 45,
                    ProcedureName = "PELVIC XRAY",
                    Amount = 790.00M,
                    Group = "IMAGING SERVICES",
                    SubGroup = "IV. VERTEBRAL COLUMN"
                },
                new Procedure
                {
                    ProcedureID = 46,
                    ProcedureName = "CHEST PA",
                    Amount = 340.00M,
                    Group = "IMAGING SERVICES",
                    SubGroup = "V. THORACIC"
                },
                new Procedure
                {
                    ProcedureID = 47,
                    ProcedureName = "CHEST PAL",
                    Amount = 640.00M,
                    Group = "IMAGING SERVICES",
                    SubGroup = "V. THORACIC"
                },
                new Procedure
                {
                    ProcedureID = 48,
                    ProcedureName = "CHEST AP(Pedia)",
                    Amount = 340.00M,
                    Group = "IMAGING SERVICES",
                    SubGroup = "V. THORACIC"
                },
                new Procedure
                {
                    ProcedureID = 49,
                    ProcedureName = "CHEST APL (Pedia)",
                    Amount = 640.00M,
                    Group = "IMAGING SERVICES",
                    SubGroup = "V. THORACIC"
                },
                new Procedure
                {
                    ProcedureID = 50,
                    ProcedureName = "CHEST LATERAL",
                    Amount = 340.00M,
                    Group = "IMAGING SERVICES",
                    SubGroup = "V. THORACIC"
                },
                new Procedure
                {
                    ProcedureID = 51,
                    ProcedureName = "CHEST APICOLORDOTIC",
                    Amount = 340.00M,
                    Group = "IMAGING SERVICES",
                    SubGroup = "V. THORACIC"
                },
                new Procedure
                {
                    ProcedureID = 52,
                    ProcedureName = "ECG 12L WITH RS",
                    Amount = 506.00M,
                    Group = "IMAGING SERVICES",
                    SubGroup = "VI. OTHERS"
                },
                new Procedure
                {
                    ProcedureID = 53,
                    ProcedureName = "WHOLE ABDOMEN",
                    Amount = 1650.00M,
                    Group = "ULTRASOUND SERVICES",
                    SubGroup = "I. GENERAL"
                },
                new Procedure
                {
                    ProcedureID = 54,
                    ProcedureName = "UPPER ABDOMEN",
                    Amount = 1100.00M,
                    Group = "ULTRASOUND SERVICES",
                    SubGroup = "I. GENERAL"
                },
                new Procedure
                {
                    ProcedureID = 55,
                    ProcedureName = "LOWER ABDOMEN",
                    Amount = 990.00M,
                    Group = "ULTRASOUND SERVICES",
                    SubGroup = "I. GENERAL"
                },
                new Procedure
                {
                    ProcedureID = 56,
                    ProcedureName = "KUB",
                    Amount = 990.00M,
                    Group = "ULTRASOUND SERVICES",
                    SubGroup = "I. GENERAL"
                },
                new Procedure
                {
                    ProcedureID = 57,
                    ProcedureName = "KUB + PROSTATE",
                    Amount = 1155.00M,
                    Group = "ULTRASOUND SERVICES",
                    SubGroup = "I. GENERAL"
                },
                new Procedure
                {
                    ProcedureID = 58,
                    ProcedureName = "HBT",
                    Amount = 1100.00M,
                    Group = "ULTRASOUND SERVICES",
                    SubGroup = "I. GENERAL"
                },
                new Procedure
                {
                    ProcedureID = 59,
                    ProcedureName = "TRANSVAGINAL",
                    Amount = 1000.00M,
                    Group = "ULTRASOUND SERVICES",
                    SubGroup = "II. OB ULTRASOUND"
                },
                new Procedure
                {
                    ProcedureID = 60,
                    ProcedureName = "PREGNANT PELVIS/TRANS AB UTZ",
                    Amount = 1000.00M,
                    Group = "ULTRASOUND SERVICES",
                    SubGroup = "II. OB ULTRASOUND"
                },
                new Procedure
                {
                    ProcedureID = 61,
                    ProcedureName = "PELVIC UTZ W/ CERVICAL LENGTH",
                    Amount = 1500.00M,
                    Group = "ULTRASOUND SERVICES",
                    SubGroup = "II. OB ULTRASOUND"
                },
                new Procedure
                {
                    ProcedureID = 62,
                    ProcedureName = "BIOPHYSICAL PROFILE",
                    Amount = 1200.00M,
                    Group = "ULTRASOUND SERVICES",
                    SubGroup = "II. OB ULTRASOUND"
                },
                new Procedure
                {
                    ProcedureID = 63,
                    ProcedureName = "DOPPLER VELOCIMETRY",
                    Amount = 2000.00M,
                    Group = "ULTRASOUND SERVICES",
                    SubGroup = "II. OB ULTRASOUND"
                },
                new Procedure
                {
                    ProcedureID = 64,
                    ProcedureName = "CONGENITAL ANOMALY SCAN",
                    Amount = 2000.00M,
                    Group = "ULTRASOUND SERVICES",
                    SubGroup = "II. OB ULTRASOUND"
                },
                new Procedure
                {
                    ProcedureID = 65,
                    ProcedureName = "CAS W/ CERVICAL LENGTH",
                    Amount = 2500.00M,
                    Group = "ULTRASOUND SERVICES",
                    SubGroup = "II. OB ULTRASOUND"
                },
                new Procedure
                {
                    ProcedureID = 66,
                    ProcedureName = "4D UTZ PIC ALONE",
                    Amount = 1000.00M,
                    Group = "ULTRASOUND SERVICES",
                    SubGroup = "II. OB ULTRASOUND"
                },
                new Procedure
                {
                    ProcedureID = 67,
                    ProcedureName = "W/ BIOMETRY",
                    Amount = 2100.00M,
                    Group = "ULTRASOUND SERVICES",
                    SubGroup = "II. OB ULTRASOUND"
                },
                new Procedure
                {
                    ProcedureID = 68,
                    ProcedureName = "WITH BIOMETRY CD AND PIC",
                    Amount = 2900.00M,
                    Group = "ULTRASOUND SERVICES",
                    SubGroup = "II. OB ULTRASOUND"
                },
                new Procedure
                {
                    ProcedureID = 69,
                    ProcedureName = "1ST TRINUCHAL SCREEN",
                    Amount = 1300.00M,
                    Group = "ULTRASOUND SERVICES",
                    SubGroup = "II. OB ULTRASOUND"
                },
                new Procedure
                {
                    ProcedureID = 70,
                    ProcedureName = "TRANSRECTAL",
                    Amount = 1200.00M,
                    Group = "ULTRASOUND SERVICES",
                    SubGroup = "II. OB ULTRASOUND"
                },
                new Procedure
                {
                    ProcedureID = 71,
                    ProcedureName = "NON PREGNANT PELVIS",
                    Amount = 1000.00M,
                    Group = "ULTRASOUND SERVICES",
                    SubGroup = "II. OB ULTRASOUND"
                },
                new Procedure
                {
                    ProcedureID = 72,
                    ProcedureName = "POST BRONCHIAL SPIROMETRY",
                    Amount = 5300.00M,
                    Group = "ULTRASOUND SERVICES",
                    SubGroup = "III. OTHERS"
                },
                new Procedure
                {
                    ProcedureID = 73,
                    ProcedureName = "24H ABPM",
                    Amount = 3900.00M,
                    Group = "ULTRASOUND SERVICES",
                    SubGroup = "III. OTHERS"
                },
                new Procedure
                {
                    ProcedureID = 74,
                    ProcedureName = "24H HOLTER MONITORING",
                    Amount = 4400.00M,
                    Group = "ULTRASOUND SERVICES",
                    SubGroup = "III. OTHERS"
                },
                new Procedure
                {
                    ProcedureID = 75,
                    ProcedureName = "ABI",
                    Amount = 3300.00M,
                    Group = "ULTRASOUND SERVICES",
                    SubGroup = "III. OTHERS"
                },
            };
        }
    }
}
