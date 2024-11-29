using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;

namespace practice3
{
    internal class Ex4
    {
        public static void Print()
        {
            ObservableCollection<CompEquipment> equipmentCollection = CreateEquipmentCollection();
            SubscribeToCollectionChanged(equipmentCollection);

            AddEquipment(equipmentCollection, new CompEquipment("Acer", "Intel", 8, 30000));
            AddEquipment(equipmentCollection, new CompEquipment("Asus", "AMD", 16, 50000));

            RemoveEquipment(equipmentCollection);
        }

        private static ObservableCollection<CompEquipment> CreateEquipmentCollection()
        {
            return new ObservableCollection<CompEquipment>();
        }

        private static void SubscribeToCollectionChanged(ObservableCollection<CompEquipment> equipmentCollection)
        {
            equipmentCollection.CollectionChanged += CollectionChanged;
        }

        private static void AddEquipment(ObservableCollection<CompEquipment> equipmentCollection, CompEquipment equipment)
        {
            equipmentCollection.Add(equipment);
        }

        private static void RemoveEquipment(ObservableCollection<CompEquipment> equipmentCollection)
        {
            if (equipmentCollection.Any())
            {
                equipmentCollection.Remove(equipmentCollection.First());
            }
        }

        // Метод, обрабатывающий событие CollectionChanged
        private static void CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    HandleItemsAdded(e);
                    break;

                case NotifyCollectionChangedAction.Remove:
                    HandleItemsRemoved(e);
                    break;

                case NotifyCollectionChangedAction.Replace:
                    Console.WriteLine("Элемент заменен.");
                    break;

                case NotifyCollectionChangedAction.Move:
                    Console.WriteLine("Элемент перемещен.");
                    break;

                case NotifyCollectionChangedAction.Reset:
                    Console.WriteLine("Коллекция сброшена.");
                    break;
            }
        }

        private static void HandleItemsAdded(NotifyCollectionChangedEventArgs e)
        {
            foreach (CompEquipment newItem in e.NewItems)
            {
                Console.WriteLine("Добавлено: ");
                newItem.PrintInfo();
            }
        }

        private static void HandleItemsRemoved(NotifyCollectionChangedEventArgs e)
        {
            foreach (CompEquipment oldItem in e.OldItems)
            {
                Console.WriteLine("Удалено: ");
                oldItem.PrintInfo();
            }
        }
    }
}