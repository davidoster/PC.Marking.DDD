using Domain;

namespace Application {
    public interface ISectionMarkingBase {

        Task<Section> SectionMarkingService(Section section);
    }
}