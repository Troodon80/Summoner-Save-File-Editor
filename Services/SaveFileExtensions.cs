using SummonerSaveFileEditor.ViewModels;

namespace SummonerSaveFileEditor.Services
{
    public static class SaveFileExtensions
    {
        /// <summary>
        /// Determines if a save game has been loaded into the view model
        /// </summary>
        /// <param name="viewModel">The save game view model to check</param>
        /// <returns>True if a save file appears to be loaded, false otherwise</returns>
        public static bool IsLoaded(this SaveGameViewModel viewModel)
        {
            if (viewModel == null)
                return false;

            // Check for critical data that would be present in a loaded save
            bool hasHeader = viewModel.SaveFileVersion > 0;
            bool hasInventory = viewModel.Inventory != null && viewModel.Inventory.Count > 0;
            bool hasCharacters = viewModel.Joseph != null || viewModel.Flece != null || 
                                viewModel.Rosalind != null || viewModel.Jekhar != null;
            bool hasAreaData = !string.IsNullOrEmpty(viewModel.AreaMain);
            
            // A save is considered loaded if it has header info and at least one other major component
            return hasHeader && (hasInventory || hasCharacters || hasAreaData);
        }
    }
}