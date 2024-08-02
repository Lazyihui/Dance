using System;
using System.Collections.Generic;


public class PanelEleRespository {

    Dictionary<int, Panel_ArrowElement> all;

    Panel_ArrowElement[] temArray;

    public PanelEleRespository() {
        all = new Dictionary<int, Panel_ArrowElement>();
        temArray = new Panel_ArrowElement[5];
    }

    public void Add(Panel_ArrowElement entity) {
        all.Add(entity.id, entity);
    }

    public void Remove(Panel_ArrowElement entity) {
        all.Remove(entity.id);
    }

    public int TakeAll(out Panel_ArrowElement[] array) {
        if (all.Count > temArray.Length) {
            temArray = new Panel_ArrowElement[all.Count * 2];
        }
        all.Values.CopyTo(temArray, 0);

        array = temArray;
        return all.Count;

    }

    public bool TryGet(int id, out Panel_ArrowElement entity) {
        return all.TryGetValue(id, out entity);
    }

    public void Foreach(Action<Panel_ArrowElement> action) {
        foreach (var item in all.Values) {
            action(item);
        }
    }
    public Panel_ArrowElement Find(Predicate<Panel_ArrowElement> predicate) {
        foreach (Panel_ArrowElement Player in all.Values) {
            bool isMatch = predicate(Player);

            if (isMatch) {
                return Player;
            }
        }
        return null;
    }
}