//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EllipticCurves {
    using System;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;
    
    
    public partial class Calculator : ContentPage {
        
        private Entry entryX;
        
        private Entry entryY;
        
        private Entry entryN;
        
        private Label labelResult;
        
        private Button buttonAddition;
        
        private Button buttonSubstraction;
        
        private Button buttonMult;
        
        private Button buttonDivision;
        
        private Button buttonSqrtX;
        
        private Button buttonPowXY;
        
        private Button buttonInverseX;
        
        private Button buttonXModN;
        
        private void InitializeComponent() {
            this.LoadFromXaml(typeof(Calculator));
            entryX = this.FindByName<Entry>("entryX");
            entryY = this.FindByName<Entry>("entryY");
            entryN = this.FindByName<Entry>("entryN");
            labelResult = this.FindByName<Label>("labelResult");
            buttonAddition = this.FindByName<Button>("buttonAddition");
            buttonSubstraction = this.FindByName<Button>("buttonSubstraction");
            buttonMult = this.FindByName<Button>("buttonMult");
            buttonDivision = this.FindByName<Button>("buttonDivision");
            buttonSqrtX = this.FindByName<Button>("buttonSqrtX");
            buttonPowXY = this.FindByName<Button>("buttonPowXY");
            buttonInverseX = this.FindByName<Button>("buttonInverseX");
            buttonXModN = this.FindByName<Button>("buttonXModN");
        }
    }
}