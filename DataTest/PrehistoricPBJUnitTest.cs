/*
* Author: Jyad Aljohani
* File name: PrehistoricPBJUnitTest.cs
* Purpose: To unit test the PrehistoricPBJ class
*/
using Xunit;
 using DinoDiner.Data.Entrees;
using System.ComponentModel;
using DinoDiner.Data.Sides;

namespace DataTest
{
    /// <summary>
    /// Unit tests for PrehistoricPBJ
    /// </summary>
    public class PrehistoricPBJUnitTest
    {
        /// <summary>
        /// PeanutButter should default to true
        /// </summary>
        [Fact]
        public void PeanutButterShouldDefaultToTrue()
        {
            PrehistoricPBJ pbj = new();
            Assert.True(pbj.PeanutButter);
        }

        /// <summary>
        /// Should be able to set PeanutButter to
        /// true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetPeanutButter()
        {
            PrehistoricPBJ pbj = new();
            pbj.PeanutButter = false;
            Assert.False(pbj.PeanutButter);
            pbj.PeanutButter = true;
            Assert.True(pbj.PeanutButter);
        }

        /// <summary>
        /// Jelly should default to true
        /// </summary>
        [Fact]
        public void JellyShouldDefaultToTrue()
        {
            PrehistoricPBJ pbj = new();
            Assert.True(pbj.Jelly);
        }

        /// <summary>
        /// Should be able to set Jelly to
        /// true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetJelly()
        {
            PrehistoricPBJ pbj = new();
            pbj.PeanutButter = false;
            Assert.False(pbj.PeanutButter);
            pbj.PeanutButter = true;
            Assert.True(pbj.PeanutButter);
        }

        /// <summary>
        /// Toasted should default to true
        /// </summary>
        [Fact]
        public void ToastedShouldDefaultToTrue()
        {
            PrehistoricPBJ pbj = new();
            Assert.True(pbj.Toasted);
        }

        /// <summary>
        /// Should be able to set Toasted to
        /// true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetToasted()
        {
            PrehistoricPBJ pbj = new();
            pbj.PeanutButter = false;
            Assert.False(pbj.PeanutButter);
            pbj.PeanutButter = true;
            Assert.True(pbj.PeanutButter);
        }

        /// <summary>
        /// Price should always be $3.75
        /// </summary>
        /// <param name="peanutButter">If pbj contains peanut butter</param>
        /// <param name="jelly">If pbj contains jelly</param>
        /// <param name="toasted">If pbj is toasted</param>
        [InlineData(true, true, true)]
        [InlineData(true, true, false)]
        [InlineData(true, false, true)]
        [InlineData(false, true, true)]
        [InlineData(false, false, true)]
        [InlineData(true, false, false)]
        [InlineData(false, true, false)]
        [InlineData(false, false, false)]
        [Theory]
        public void PriceShouldBeCorrect(bool peanutButter, bool jelly, bool toasted)
        {
            PrehistoricPBJ pbj = new()
            {
                PeanutButter = peanutButter,
                Jelly = jelly,
                Toasted = toasted
            };
            Assert.Equal(3.75m, pbj.Price);
        }

        /// <summary>
        /// Calories varies based on how the PBJ is made
        /// </summary>
        /// <details>
        /// 148 calories for the bread
        /// 188 calories for the peanut butter 
        /// 62 calories for the jelly
        /// </details>
        /// <param name="peanutButter">If pbj contains peanut butter</param>
        /// <param name="jelly">If pbj contains jelly</param>
        /// <param name="toasted">If pbj is toasted</param>
        /// <param name="calories">The expected calories</param>
        [InlineData(true, true, true, 148+188+62)]
        [InlineData(true, true, false, 148+188+62)]
        [InlineData(true, false, true, 148+188)]
        [InlineData(false, true, true, 148+62)]
        [InlineData(false, false, true, 148)]
        [InlineData(true, false, false, 148+188)]
        [InlineData(false, true, false, 148+62)]
        [InlineData(false, false, false, 148)]
        [Theory]
        public void CaloriesShouldBeCorrect(bool peanutButter, bool jelly, bool toasted, uint calories)
        {
            PrehistoricPBJ pbj = new()
            {
                PeanutButter = peanutButter,
                Jelly = jelly,
                Toasted = toasted
            };
            Assert.Equal(calories, pbj.Calories);
        }

        /// <summary>
        /// Name varies based on how the PBJ is made
        /// </summary>
        /// <details>
        /// 148 calories for the bread
        /// 188 calories for the peanut butter 
        /// 62 calories for the jelly
        /// </details>
        /// <param name="peanutButter">If pbj contains peanut butter</param>
        /// <param name="jelly">If pbj contains jelly</param>
        /// <param name="toasted">If pbj is toasted</param>
        /// <param name="calories">The expected calories</param>
        [Theory]
        [InlineData(true, true, true)]
        [InlineData(true, true, false)]
        [InlineData(true, false, true)]
        [InlineData(false, true, true)]
        [InlineData(false, false, true)]
        [InlineData(true, false, false)]
        [InlineData(false, false, false)]
        public void NameShouldBeCorrect(bool peanutButter, bool jelly, bool toasted)
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            pbj.PeanutButter = peanutButter;
            pbj.Jelly = jelly;
            pbj.Toasted = toasted;
            Assert.Equal("Prehistoric PBJ", pbj.Name);
        }

        /// <summary>
        /// Checks that PrehistoricPBJ class inherit from Entree
        /// </summary>
        [Fact]
        public void PrehistoricPBJShouldInheritFromEntree()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            Assert.IsAssignableFrom<Entree>(pbj);
        }

        /// <summary>
        /// Checks whether INotifyPropertyChanged can be implemented.
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(pbj);
        }


        /// <summary>
        /// Checks notification of property Changed when peanutbutter changes.
        /// </summary>
        /// <param name="peanutbutter">Whether peanutbutter is added to the order</param>
        /// <param name="propertyName">The property to check</param>
        [Theory]
        [InlineData(false, "PeanutButter")]
        [InlineData(true, "PeanutButter")]
        [InlineData(false, "Calories")]
        [InlineData(true, "Calories")]
        public void ShouldNotifyOfPropertyChangedWhenPeanutButterChanges(bool peanutbutter, string propertyName)
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            // A quick hack to avoid not changing peanutButter when setting to the default peanutButter.
            if (peanutbutter) pbj.PeanutButter = false;
            Assert.PropertyChanged(pbj, propertyName, () =>
            {
                pbj.PeanutButter = peanutbutter;
            });
        }
        /// <summary>
        /// Checks notification of property Changed when Jelly changes.
        /// </summary>
        /// <param name="jelly">Whether Jelly is added to the order</param>
        /// <param name="propertyName">The property to check</param>
        [Theory]
        [InlineData(false, "Jelly")]
        [InlineData(true, "Jelly")]
        [InlineData(false, "Calories")]
        [InlineData(true, "Calories")]
        public void ShouldNotifyOfPropertyChangedWhenJellyChanges(bool jelly, string propertyName)
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            // A quick hack to avoid not changing Jelly when setting to the default Jelly.
            if (jelly) pbj.Jelly = false;
            Assert.PropertyChanged(pbj, propertyName, () =>
            {
                pbj.Jelly = jelly;
            });
        }

        /// <summary>
        /// Checks whether the overridden method ToString() returns the expected value.
        /// </summary>
        [Fact]
        public void ToStringShouldReturnExpectedValue()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            Assert.Equal($"{pbj.Name}", pbj.ToString());
        }
    }
}