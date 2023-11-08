using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Cittadino
    {
        /// <summary>
        ///    Cette classe représente un citoyen
        /// </summary>
        public class Citoyen
        {
            #region Constructeur

            /// <summary>
            ///     Initialise une nouvelle instance de la classe <see cref="Citoyen"/>
            /// </summary>
            /// <param name="isMilitaryDone">
            ///    si il a fait le millitaire
            /// </param>
            /// <param name="age">
            ///     age du citoyen
            /// </param>
            /// <param name="bachelorAvarage">
            ///     moyenne en licence
            /// </param>
            /// <param name="universityAvarage">
            ///     moyenne à l'université
            /// </param>
            /// <param name="hasCredit">
            ///     a un crédit
            /// </param>
            /// <param name="numberOfChildren">
            ///      nombre d'enfant
            /// </param>
            /// <param name="pIBCommune">
            ///     pid de la commune
            /// </param>
            public Citoyen(bool isMilitaryDone,
                           int age,
                           double bachelorAvarage,
                           double universityAvarage,
                           int numberOfChildren,
                           int pIBCommune,
                           bool hasCredit,
                           bool isStudent
                          )
            {
                this.IsMilitaryDone = isMilitaryDone;
                this.Age = age;
                this.BachelorAvarage = bachelorAvarage;
                this.UniversityAvarage = universityAvarage;
                this.NumberOfChildren = numberOfChildren;
                this.HasCredit = hasCredit;
                this.PIBCommune = pIBCommune;
                this.HasCredit = hasCredit;
                this.IsStudent = isStudent;
            }

            #endregion


            #region Méthodes publiques

            /// <summary>
            ///     Permet de savoir si le citoyen 
            ///     a le droit de recevoir l'aide social ou pas
            /// </summary>
            /// <returns>
            ///     <see langword="true"/>
            ///     si il a le droit
            ///     <see langword="false"/>
            ///     sinon
            /// </returns>
            public bool HasRightToGetSocialMoney()
            {
                bool result = false;

                //Si il n'a pas de millitaire on retourne directement false
                if (!this.IsMilitaryDone)
                {
                    return result;
                }

                if (this.IsStudent)
                {
                    if (this.Age >= 18
                        && this.Age <= 25
                        && this.BachelorAvarage > 90
                        && this.UniversityAvarage > 28
                        && this.NumberOfChildren > 1
                        && this.PIBCommune < 100
                        && this.HasCredit
                    )
                    {
                        result = true;
                    }
                }
                else
                {
                    if (this.Age > 60
                        && this.NumberOfChildren > 1
                        && this.PIBCommune < 100
                        && this.HasCredit
                    )
                    {
                        result = true;
                    }
                }

                return result;
            }

            #endregion


            #region Propriété publiques

            /// <summary>
            ///     Obtient ou définit
            ///     la valeur permettant de savoir si il a déjà fait
            ///     le millitaire
            /// </summary>
            public bool IsMilitaryDone { get; set; }

            /// <summary>
            ///     Obtient ou définit
            ///     age du citoyen
            /// </summary>
            public int Age { get; set; }

            /// <summary>
            ///     Obtient ou définit
            ///     la moyenne en licence
            /// </summary>
            public double BachelorAvarage { get; set; }

            /// <summary>
            ///     Obtient ou définit
            ///     la moyenne universitaire
            /// </summary>
            public double UniversityAvarage { get; set; }

            /// <summary>
            ///     Obtient ou définit
            ///     le nombre d'enfants du citoyen
            /// </summary>
            public int NumberOfChildren { get; set; }

            /// <summary>
            ///     Obtient ou définit
            ///     Le PIB de la commune
            /// </summary>
            public int PIBCommune { get; set; }

            /// <summary>
            ///     Obtient ou définit
            ///     la valeur permettant de savoir si
            ///     le citoyen a un crédit
            /// </summary>
            public bool HasCredit { get; set; }

            /// <summary>
            ///     Obtient ou définit
            ///     la valeur permettant de savoir si
            ///     le citoyen est un universitaire
            /// </summary>
            public bool IsStudent { get; set; }

            #endregion


        }

    }
}
