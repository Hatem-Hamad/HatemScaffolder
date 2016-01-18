﻿using AwesomeGridScaffolder;
using AwesomeGridScaffolder.WebForms;
using Microsoft.AspNet.Scaffolding;
using System;
using System.ComponentModel.Composition;
using System.Drawing;
using System.Runtime.Versioning;
using System.Windows;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace AwesomeGridScaffolder
{
    [Export(typeof(CodeGeneratorFactory))]
    public class AwesomeGridScaffolderFactory : CodeGeneratorFactory
    {
        public AwesomeGridScaffolderFactory()
            : base(_info)
        {
        }
        /// <summary>
        /// This method creates the code generator instance.
        /// </summary>
        /// <param name="context">The context has details on current active project, project item selected, Nuget packages that are applicable and service provider.</param>
        /// <returns>Instance of CodeGenerator.</returns>
        public override ICodeGenerator CreateInstance(CodeGenerationContext context)
        {
            return new AwesomeGridScaffolderClass(context, Information);
        }

        /// <summary>
        /// Provides a way to check if the custom scaffolder is valid under this context
        /// </summary>
        /// <param name="codeGenerationContext">The code generation context</param>
        /// <returns>True if valid, False otherwise</returns>
        public override bool IsSupported(CodeGenerationContext codeGenerationContext)
        {
            if (codeGenerationContext.ActiveProject.CodeModel.Language != EnvDTE.CodeModelLanguageConstants.vsCMLanguageCSharp)
            {
                return false;
            }

            return true;
        }


        /// <summary>
        ///  Information about the code generator goes here.
        /// </summary>
        private static CodeGeneratorInformation _info = new CodeGeneratorInformation(
            displayName: "Awesome Grid Scaffolder",
            description: "Creates custom Grids based on EF and MVCAwesome Project.",
            author: "Hatem Hamad",
            version: new Version(1, 0, 0, 0),
            id: typeof(AwesomeGridScaffolderClass).Name,
            icon:null, //TODO :ToImageSource(Resources._TemplateIconSample),
            gestures: new[] { "Controller", "View", "Area" },
            categories: new[] { Categories.Common, Categories.MvcController, Categories.MvcView, Categories.Other
            });


        /// <summary>
        /// Helper method to convert Icon to Imagesource.
        /// </summary>
        /// <param name="icon">Icon</param>
        /// <returns>Imagesource</returns>
        public static ImageSource ToImageSource(Icon icon)
        {
            ImageSource imageSource = Imaging.CreateBitmapSourceFromHIcon(
                icon.Handle,
                Int32Rect.Empty,
                BitmapSizeOptions.FromEmptyOptions());

            return imageSource;
        }
    }
}
