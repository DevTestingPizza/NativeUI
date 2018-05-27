using System;
using System.Collections.Generic;


using Font = CitizenFX.Core.UI.Font;
using System.Drawing;

namespace NativeUI
{
    public class UIMenuHeritageCardItem : UIMenuItem
    {
        //protected Sprite _arrowLeft;
        //protected Sprite _arrowRight;
        protected Sprite _background = new Sprite("pause_menu_pages_char_mom_dad", "mumdadbg", new PointF(1390f, 209f), new SizeF(481f, 228f));
        //protected Sprite _background = new Sprite("pause_menu_pages_char_mom_dad", "mumdadbg", new PointF(1390f, 215f), new SizeF(481f, 210f));

        //protected UIResRectangle _rectangleBackground;
        //protected UIResRectangle _rectangleSlider;
        //protected UIResRectangle _rectangleDivider;

        //protected List<dynamic> _items;


        protected int mom;
        protected int dad;

        /// <summary>
        /// Returns the current selected mom index.
        /// </summary>
        public int Mom
        {
            get { return mom; }
            set { mom = value; _mom.TextureName = $"Female_{value}"; }
        }

        /// <summary>
        /// Returns the current selected dad index.
        /// </summary>
        public int Dad
        {
            get { return dad; }
            set { dad = value; _dad.TextureName = $"Male_{value}"; }
        }

        public Sprite _mom = new Sprite("CHAR_CREATOR_PORTRAITS", "Female_0", new PointF(1420f, 209f), new SizeF(228f, 228f));
        public Sprite _dad = new Sprite("CHAR_CREATOR_PORTRAITS", "Male_0", new PointF(1420f + 190f, 209f), new SizeF(228f, 228f));

        public UIMenuHeritageCardItem(int mom, int dad) : base(" ")
        {

        }



        ///// <summary>
        ///// List item, with slider.
        ///// </summary>
        ///// <param name="text">Item label.</param>
        ///// <param name="items">List that contains your items.</param>
        ///// <param name="index">Index in the list. If unsure user 0.</param>
        //public UIMenuSliderItem(string text, List<dynamic> items, int index)
        //    : this(text, items, index, "", false)
        //{
        //}

        ///// <summary>
        ///// List item, with slider.
        ///// </summary>
        ///// <param name="text">Item label.</param>
        ///// <param name="items">List that contains your items.</param>
        ///// <param name="index">Index in the list. If unsure user 0.</param>
        ///// <param name="description">Description for this item.</param>
        //public UIMenuSliderItem(string text, List<dynamic> items, int index, string description)
        //    : this(text, items, index, description, false)
        //{
        //}

        ///// <summary>
        ///// List item, with slider.
        ///// </summary>
        ///// <param name="text">Item label.</param>
        ///// <param name="items">List that contains your items.</param>
        ///// <param name="index">Index in the list. If unsure user 0.</param>
        ///// <param name="description">Description for this item.</param>
        ///// /// <param name="divider">Put a divider in the center of the slider</param>
        //public UIMenuSliderItem(string text, List<dynamic> items, int index, string description, bool divider)
        //    : base(text, description)
        //{
        //    const int y = 0;
        //    _items = new List<dynamic>(items);
        //    _arrowLeft = new Sprite("commonmenutu", "arrowleft", new PointF(0, 105 + y), new SizeF(15f, 15f));
        //    _arrowRight = new Sprite("commonmenutu", "arrowright", new PointF(0, 105 + y), new SizeF(15f, 15f));
        //    _rectangleBackground = new UIResRectangle(new PointF(50f, 0), new SizeF(150, 9), Color.FromArgb(255, 4, 32, 57));
        //    _rectangleSlider = new UIResRectangle(new PointF(50f, 0), new SizeF(75, 9), Color.FromArgb(255, 57, 116, 200));
        //    if (divider)
        //    {
        //        _rectangleDivider = new UIResRectangle(new PointF(50f, 0), new SizeF(2.5f, 20), UnknownColors.WhiteSmoke);
        //    }
        //    else
        //    {
        //        _rectangleDivider = new UIResRectangle(new PointF(50f, 0), new SizeF(2.5f, 20), UnknownColors.Transparent);
        //    }
        //    Index = index;
        //}

        /// <summary>
        /// Change item's position.
        /// </summary>
        /// <param name="y">New Y position.</param>
        public override void Position(int y)
        {
            //_rectangleBackground.Position = new PointF(250 + Offset.X + 50f, y + 158.5f + Offset.Y);
            //_rectangleSlider.Position = new PointF(250 + Offset.X, y + 158.5f + Offset.Y);
            //_rectangleDivider.Position = new PointF(323.5f + Offset.X + 50f, y + 153 + Offset.Y);
            //_arrowLeft.Position = new PointF(235 + Offset.X + Parent.WidthOffset, 155.5f + y + Offset.Y);
            //_arrowRight.Position = new PointF(400 + Offset.X + Parent.WidthOffset, 155.5f + y + Offset.Y);

            base.Position(y);
        }





        /// <summary>
        /// Draw item.
        /// </summary>
        public override void Draw()
        {
            //_rectangle.Size = new SizeF(_rectangle.Size.Width, 400f);
            //_rectangle.Position = new PointF(0f, 400f);
            base.Draw();
            //_rectangle.Size = new SizeF(_rectangle.Size.Width, 400f);
            //_rectangle.Color = UnknownColors.Transparent;

            _background.Draw();
            _dad.Draw();
            _mom.Draw();

            //_rectangle.Draw(new SizeF(50f, 600f));



            //_arrowLeft.Color = Enabled ? Selected ? UnknownColors.Black : UnknownColors.WhiteSmoke : Color.FromArgb(163, 159, 148);
            //_arrowRight.Color = Enabled ? Selected ? UnknownColors.Black : UnknownColors.WhiteSmoke : Color.FromArgb(163, 159, 148);
            //float offset = ((_rectangleBackground.Size.Width - _rectangleSlider.Size.Width) / (_items.Count - 1)) * Index;
            //_rectangleSlider.Position = new PointF(250 + Offset.X + offset + 50f, _rectangleSlider.Position.Y);
            ////_rectangleBackground.Position = new PointF(_rectangleBackground.Position.X + 50f, _rectangleBackground.Position.Y);
            //if (Selected)
            //{
            //    _arrowLeft.Draw();
            //    _arrowRight.Draw();
            //}
            //else
            //{

            //}
            //_rectangleBackground.Draw();
            //_rectangleSlider.Draw();
            //_rectangleDivider.Draw();
        }

        //internal virtual void SliderChangedTrigger(int newindex)
        //{
        //    OnSliderChanged?.Invoke(this, newindex);
        //}

        //internal virtual void SliderSelectedTrigger(int newindex)
        //{
        //    OnSliderSelected?.Invoke(this, newindex);
        //}
    }
}
